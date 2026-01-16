using System;
using System.Collections.Generic;
using System.Linq;

namespace GourmetOS.System;

// ==========================================
// ENUMS Y DATOS COMUNES
// ==========================================

public enum CategoriaPlato { Entrante, Primero, Segundo, Postre }

// ==========================================
// PERSONAL (HERENCIA Y TUTORÍA)
// ==========================================

public abstract class Empleado(string dni, string nombre)
{
    public string DNI { get; } = dni;
    public string Nombre { get; set; } = nombre;
    public string Telefono { get; set; } = string.Empty;
}

public class Cocinero(string dni, string nombre, int aniosServicio) : Empleado(dni, nombre)
{
    public int AniosServicio { get; set; } = aniosServicio;
    
    // Relación: Un cocinero sabe hacer muchos platos
    public List<Plato> Repertorio { get; } = new();

    // Relación: Mentoriza a muchos pinches
    public List<Pinche> EquipoACargo { get; } = new();

    public void AgregarPinche(Pinche p)
    {
        if (!EquipoACargo.Contains(p)) EquipoACargo.Add(p);
    }
}

public class Pinche : Empleado
{
    public DateTime FechaNacimiento { get; }
    public Cocinero Mentor { get; private set; }

    // Regla de Negocio: Un pinche NO puede existir sin mentor.
    // Lo forzamos en el constructor.
    public Pinche(string dni, string nombre, DateTime fechaNac, Cocinero mentor) 
        : base(dni, nombre)
    {
        FechaNacimiento = fechaNac;
        AsignarMentor(mentor);
    }

    public void AsignarMentor(Cocinero nuevoMentor)
    {
        Mentor = nuevoMentor ?? throw new ArgumentNullException(nameof(nuevoMentor));
        nuevoMentor.AgregarPinche(this); // Mantener coherencia bidireccional
    }
}

// ==========================================
// PRODUCCIÓN (PLATOS E INGREDIENTES)
// ==========================================

public class Ingrediente(string nombre)
{
    public string Nombre { get; } = nombre;
    // Equals y HashCode deberían implementarse para comparaciones correctas
}

public class Plato(string nombre, decimal precio, CategoriaPlato categoria)
{
    public string Nombre { get; } = nombre;
    public decimal Precio { get; set; } = precio;
    public CategoriaPlato Categoria { get; } = categoria;

    // Composición: El plato tiene ingredientes con cantidades específicas
    private readonly List<LineaReceta> _receta = new();

    public void AgregarIngrediente(Ingrediente ing, double cantidad, string unidad)
    {
        _receta.Add(new LineaReceta(ing, cantidad, unidad));
    }
    
    public IEnumerable<LineaReceta> ObtenerReceta() => _receta;
}

// Clase intermedia para la relación N:M con atributos
public class LineaReceta(Ingrediente ing, double cant, string unidad)
{
    public Ingrediente Ingrediente { get; } = ing;
    public double CantidadNecesaria { get; } = cant;
    public string UnidadMedida { get; } = unidad;
}

// ==========================================
// ALMACÉN Y STOCK
// ==========================================

public class Almacen(int numero, string descripcion)
{
    public int Numero { get; } = numero;
    public string Descripcion { get; } = descripcion;
    
    // Composición: Si el almacén cierra, los estantes desaparecen
    public List<Estante> Estantes { get; } = new();

    public void AgregarEstante(string codigo, double tamanio)
    {
        Estantes.Add(new Estante(this, codigo, tamanio));
    }
}

public class Estante(Almacen almacen, string codigo, double tamanio)
{
    public Almacen Ubicacion { get; } = almacen; // Referencia al todo
    public string CodigoLetras { get; } = codigo;
    public double Tamanio { get; } = tamanio;

    // Diccionario para gestión rápida de stock: Ingrediente -> Cantidad
    private readonly Dictionary<Ingrediente, double> _inventario = new();

    public void AgregarStock(Ingrediente ing, double cantidad)
    {
        if (_inventario.ContainsKey(ing))
            _inventario[ing] += cantidad;
        else
            _inventario[ing] = cantidad;
    }

    public bool RetirarStock(Ingrediente ing, double cantidad)
    {
        if (!_inventario.ContainsKey(ing) || _inventario[ing] < cantidad)
            return false; // No hay suficiente stock

        _inventario[ing] -= cantidad;
        return true;
    }
}
