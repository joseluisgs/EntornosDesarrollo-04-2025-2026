using System;
using System.Collections.Generic;

namespace SkyHigh.System;

// ==========================================
// INFRAESTRUCTURA (AEROPUERTOS Y AVIONES)
// ==========================================

public record Aeropuerto(string CodigoIATA, string Ciudad, string Pais);

public class Asiento(int fila, char letra, int planta)
{
    public int Fila { get; } = fila;
    public char Letra { get; } = letra;
    public int Planta { get; } = planta;
    public string CodigoCompleto => $"{Fila}{Letra}-P{Planta}";
}

public class Avion(string matricula, string modelo)
{
    public string Matricula { get; } = matricula;
    public string Modelo { get; } = modelo;
    
    // Composición: Los asientos son parte física del avión
    public List<Asiento> MapaAsientos { get; } = new();

    public void ConfigurarAsientos(int filas, int plantas)
    {
        for (int p = 1; p <= plantas; p++)
            for (int f = 1; f <= filas; f++)
            {
                MapaAsientos.Add(new Asiento(f, 'A', p));
                MapaAsientos.Add(new Asiento(f, 'B', p));
                // Simplificado...
            }
    }
}

// ==========================================
// OPERATIVA DE VUELO
// ==========================================

public class Vuelo(string codigo, Aeropuerto origen, Aeropuerto destino, Avion avion)
{
    public string CodigoVuelo { get; } = codigo;
    public Aeropuerto Origen { get; } = origen;
    public Aeropuerto Destino { get; } = destino;
    public Avion AvionAsignado { get; } = avion; // El avión que opera este vuelo concreto
    
    public DateTime SalidaProgramada { get; set; }
    public DateTime LlegadaProgramada { get; set; }
}

// ==========================================
// CLIENTE Y RESERVAS
// ==========================================

public class Cliente(string dni, string nombre)
{
    public string DNI { get; } = dni;
    public string Nombre { get; set; } = nombre;
    
    // Dato sensible encapsulado
    private string _tarjetaCreditoHash; 

    public void GuardarTarjeta(string numeroTarjeta)
    {
        // Simulación de hash
        _tarjetaCreditoHash = $"HASH-{numeroTarjeta.GetHashCode()}";
    }
}

public class Reserva(Cliente cliente, Vuelo vuelo, int plazas)
{
    public string Localizador { get; } = Guid.NewGuid().ToString()[..6].ToUpper();
    public Cliente Titular { get; } = cliente;
    public Vuelo VueloReservado { get; } = vuelo;
    public int NumPasajeros { get; } = plazas;
    public bool EstaConfirmada { get; set; } = false;

    // Una reserva puede derivar en múltiples tarjetas de embarque
    public List<TarjetaEmbarque> CheckInRealizados { get; } = new();
}

// ==========================================
// CHECK-IN (DOCUMENTO FINAL)
// ==========================================

public class TarjetaEmbarque
{
    public string CodigoQR { get; }
    public Vuelo Vuelo { get; }
    public Asiento AsientoAsignado { get; }
    public string NombrePasajero { get; } // Puede ser distinto al titular de la reserva

    // Caso A: Check-in desde una Reserva existente
    public TarjetaEmbarque(Reserva reserva, string nombrePasajero, Asiento asiento)
    {
        Vuelo = reserva.VueloReservado;
        NombrePasajero = nombrePasajero;
        AsientoAsignado = asiento;
        CodigoQR = GenerarQR();
        reserva.CheckInRealizados.Add(this);
    }

    // Caso B: Venta directa en mostrador (Sin reserva previa)
    public TarjetaEmbarque(Vuelo vuelo, string nombrePasajero, Asiento asiento)
    {
        Vuelo = vuelo;
        NombrePasajero = nombrePasajero;
        AsientoAsignado = asiento;
        CodigoQR = GenerarQR();
    }

    private string GenerarQR() => $"{Vuelo.CodigoVuelo}|{AsientoAsignado.CodigoCompleto}|{DateTime.Now.Ticks}";
}
