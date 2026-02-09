using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ConnectX.System;

// ==========================================
// DEFINICIÓN DE INTERFACES (Estrategia de Visibilidad)
// ==========================================

public interface IVisible
{
    bool EsVisiblePara(Usuario autor, Usuario lector);
}

public class VisibilidadGlobal : IVisible
{
    public bool EsVisiblePara(Usuario autor, Usuario lector) => true;
}

public class VisibilidadGrupo(GrupoContactos grupoPermitido) : IVisible
{
    public bool EsVisiblePara(Usuario autor, Usuario lector) 
        => grupoPermitido.Miembros.Contains(lector) || autor == lector;
}

// ==========================================
// CLASES PRINCIPALES
// ==========================================

public class Usuario
{
    // Identificadores y Seguridad
    public Guid Id { get; } = Guid.NewGuid();
    private string _passwordHash;
    
    // Datos Personales (Properties)
    public string Nombre { get; set; }
    // 'virtual' permite sobrescribir el comportamiento en hijas (Celebridad)
    public virtual string Email { get; set; } 
    public virtual string Direccion { get; set; }
    public byte[] FotoPerfil { get; set; } = Array.Empty<byte>();

    // Relaciones
    private readonly List<Vinculo> _agenda = new();
    private readonly List<GrupoContactos> _misGrupos = new();
    private readonly HashSet<Usuario> _bloqueados = new();
    private readonly List<Post> _muro = new();

    // Primary Constructor simulado en cuerpo (C# standard style)
    public Usuario(string nombre, string email, string direccion, string password)
    {
        Nombre = nombre;
        Email = email;
        Direccion = direccion;
        _passwordHash = Encriptar(password);
    }

    // Comportamientos
    public void AgregarContacto(Usuario contacto, string notaPersonal)
    {
        if (_bloqueados.Contains(contacto)) 
            throw new InvalidOperationException("No puedes añadir a un usuario bloqueado.");
            
        _agenda.Add(new Vinculo(this, contacto, notaPersonal));
    }

    public void CrearGrupo(string nombre)
    {
        _misGrupos.Add(new GrupoContactos(nombre, this));
    }

    public void BloquearUsuario(Usuario molesto)
    {
        _bloqueados.Add(molesto);
        // Lógica adicional: eliminar de contactos, etc.
    }

    public void PublicarPost(string texto, IVisible visibilidad)
    {
        var post = new Post(this, texto, visibilidad);
        _muro.Add(post);
    }

    // Método para mostrar datos (Polimorfismo en acción)
    public virtual string ObtenerFichaPublica()
    {
        return $"[ID: {Id}] Nombre: {Nombre} | Email: {Email} | Loc: {Direccion}";
    }

    // Simulación de encriptación
    private static string Encriptar(string pass) => Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(pass)));
}

// ==========================================
// HERENCIA: USUARIO CELEBRIDAD
// ==========================================

public class UsuarioCelebridad : Usuario
{
    public UsuarioCelebridad(string nombre, string email, string direccion, string password) 
        : base(nombre, email, direccion, password) { }

    // Sobreescritura (Override) para ocultar datos sensibles
    // Nota: En un sistema real, esto se gestionaría a nivel de DTO, 
    // pero aquí simulamos el comportamiento de la clase de dominio.
    public override string ObtenerFichaPublica()
    {
        return $"[ID: {Id}] Nombre: {Nombre} (Verificado) | Email: **** | Loc: ****";
    }
}

// ==========================================
// CLASES AUXILIARES Y RELACIONES
// ==========================================

// Clase intermedia para la relación N:M con atributos (nota personal)
public class Vinculo(Usuario origen, Usuario destino, string nota)
{
    public Usuario UsuarioOrigen { get; } = origen;
    public Usuario UsuarioDestino { get; } = destino;
    public string NotaPersonal { get; set; } = nota;
    public DateTime FechaAmistad { get; } = DateTime.Now;
}

public class GrupoContactos(string nombre, Usuario propietario)
{
    public string Nombre { get; set; } = nombre;
    public Usuario Propietario { get; } = propietario;
    public List<Usuario> Miembros { get; } = new();

    public void AgregarMiembro(Usuario u) => Miembros.Add(u);
}

public class Post(Usuario autor, string texto, IVisible visibilidad)
{
    public Guid Id { get; } = Guid.NewGuid();
    public Usuario Autor { get; } = autor;
    public string Texto { get; } = texto;
    public DateTime Fecha { get; } = DateTime.Now;
    public IVisible Visibilidad { get; } = visibilidad;

    public bool PuedeVer(Usuario lector)
    {
        // Si el lector está bloqueado por el autor, nunca puede ver nada
        // (Acceso a lógica interna del autor, posible si están en el mismo assembly o mediante método público)
        // Aquí asumimos una comprobación básica.
        return Visibilidad.EsVisiblePara(Autor, lector);
    }
}
