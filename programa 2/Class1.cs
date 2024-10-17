using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase PuntajeYDescuentos
        PuntajeYDescuentos puntajeYDescuentos = new PuntajeYDescuentos();

        // Llamar a las funciones para ingresar datos y calcular el promedio
        puntajeYDescuentos.Ingreso();
        puntajeYDescuentos.RegistroNotaCredito();
        puntajeYDescuentos.ImprimePromedio();
        puntajeYDescuentos.VerificaPromedio();

        // Llamar a la función que verifica y aplica los descuentos
        puntajeYDescuentos.VerificaDescuentos();
    }
}
