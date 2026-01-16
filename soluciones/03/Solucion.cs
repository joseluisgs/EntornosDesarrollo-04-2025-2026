using System;
using System.Collections.Generic;
using System.Linq;

namespace AgileFactory.System;

// ==========================================
// ENTIDADES DE CATÁLOGO
// ==========================================

// No usamos Enum porque el enunciado pide "definir nuevas profesiones dinámicamente"
public class Profesion(string nombre, decimal tarifaHora)
{
    public string Nombre { get; set; } = nombre; // Ej: "Analista", "DBA"
    public decimal TarifaHora { get; set; } = tarifaHora;
}

// ==========================================
// ACTORES
// ==========================================

public class Cliente(string cif, string codigo, string nombre)
{
    public string CIF { get; } = cif;
    public string CodigoInterno { get; } = codigo;
    public string NombreEmpresa { get; set; } = nombre;
    
    public List<Proyecto> ProyectosContratados { get; } = new();
}

public class Trabajador(string codigo, string dni, string nombre)
{
    public string CodigoEmpleado { get; } = codigo;
    public string DNI { get; } = dni;
    public string Nombre { get; set; } = nombre;

    // Histórico de asignaciones
    public List<AsignacionProyecto> HistorialProyectos { get; } = new();
}

// ==========================================
// GESTIÓN DE PROYECTOS
// ==========================================

public class Proyecto(string nombre, DateTime inicio, DateTime finPrevisto, Cliente cliente)
{
    public string Nombre { get; set; } = nombre;
    public DateTime FechaInicio { get; } = inicio;
    public DateTime FechaFinPrevista { get; set; } = finPrevisto;
    public DateTime? FechaFinReal { get; set; } = null; // Nullable: puede no haber terminado

    public Cliente ClientePropietario { get; } = cliente;
    
    // Composición: Las asignaciones pertenecen al contexto del proyecto
    private readonly List<AsignacionProyecto> _equipo = new();
    public IEnumerable<AsignacionProyecto> Equipo => _equipo;

    public void AsignarTrabajador(Trabajador t, Profesion rol)
    {
        var asignacion = new AsignacionProyecto(this, t, rol);
        _equipo.Add(asignacion);
        t.HistorialProyectos.Add(asignacion); // Mantener coherencia bidireccional
    }

    public void CerrarProyecto()
    {
        FechaFinReal = DateTime.Now;
    }
}

// ==========================================
// CLASE RELACIÓN (N:M con Atributos)
// ==========================================

public class AsignacionProyecto(Proyecto p, Trabajador t, Profesion rol)
{
    public Proyecto ProyectoRef { get; } = p;
    public Trabajador TrabajadorRef { get; } = t;
    public Profesion RolDesempenado { get; private set; } = rol; // El rol puede cambiar en otro proyecto
    
    public double HorasDedicadas { get; private set; } = 0;

    public void RegistrarHoras(double horas)
    {
        if (horas < 0) throw new ArgumentException("Horas no válidas");
        HorasDedicadas += horas;
    }

    public void CambiarRol(Profesion nuevoRol)
    {
        // Lógica de negocio: ¿Se puede cambiar rol a mitad de proyecto?
        // Asumimos que sí.
        RolDesempenado = nuevoRol;
    }
}
