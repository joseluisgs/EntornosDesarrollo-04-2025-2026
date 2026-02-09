using System;
using System.Collections.Generic;

namespace AtlasGeografico.System;

// ==========================================
// AUXILIARES
// ==========================================

public record Coordenada(double Latitud, double Longitud);

// ==========================================
// CLASE RELACIÓN (Rompiendo N:M)
// ==========================================

public class PresenciaGeografica(Pais p, AccidenteGeografico a, string nombreLocal)
{
    public Pais PaisRef { get; } = p;
    public AccidenteGeografico AccidenteRef { get; } = a;
    
    // Atributo específico de la relación
    public string NombreLocal { get; } = nombreLocal; 
}

// ==========================================
// GEOPOLÍTICA
// ==========================================

public class Pais(string nombre, double extension, long poblacion)
{
    public string Nombre { get; } = nombre;
    public double ExtensionKm2 { get; } = extension;
    public long Poblacion { get; } = poblacion;

    // Relación 1:N hacia la clase intermedia
    public List<PresenciaGeografica> InventarioGeografico { get; } = new();

    public void VincularAccidente(PresenciaGeografica presencia)
    {
        InventarioGeografico.Add(presencia);
    }
}

// ==========================================
// JERARQUÍA DE ACCIDENTES
// ==========================================

public abstract class AccidenteGeografico(string nombre, Coordenada ubicacion)
{
    public string NombreInternacional { get; } = nombre;
    public Coordenada UbicacionCentral { get; } = ubicacion;

    // Relación 1:N hacia la clase intermedia
    public List<PresenciaGeografica> PaisesAfectados { get; } = new();

    public void RegistrarPais(Pais pais, string nombreLocal)
    {
        // Creamos la relación intermedia
        var vinculo = new PresenciaGeografica(pais, this, nombreLocal);
        
        // Añadimos a nuestra lista
        PaisesAfectados.Add(vinculo);
        
        // Mantenemos coherencia bidireccional notificando al país
        pais.VincularAccidente(vinculo);
    }
    
    public abstract string ObtenerFichaTecnica();
}

public class Rio(string nombre, Coordenada ubicacion, double longitud) 
    : AccidenteGeografico(nombre, ubicacion)
{
    public double LongitudKm { get; } = longitud;

    public override string ObtenerFichaTecnica() 
        => $"Río {NombreInternacional}: {LongitudKm} km de longitud.";
}

public class Montania(string nombre, Coordenada ubicacion, double altura) 
    : AccidenteGeografico(nombre, ubicacion)
{
    public double AlturaMetros { get; } = altura;

    public override string ObtenerFichaTecnica() 
        => $"Pico {NombreInternacional}: {AlturaMetros} m de altitud.";
}

public class Lago(string nombre, Coordenada ubicacion, double superficie) 
    : AccidenteGeografico(nombre, ubicacion)
{
    public double SuperficieKm2 { get; } = superficie;

    public override string ObtenerFichaTecnica() 
        => $"Lago {NombreInternacional}: {SuperficieKm2} km² de espejo de agua.";
}