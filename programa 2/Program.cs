using System;

public class PuntajeYDescuentos
{
    // Variables para almacenar los datos
    public int n; // Número de cursos
    public double mensualidad;
    public double promedioPonderado;

    // Función para ingresar el número de cursos y la mensualidad
    public void Ingreso()
    {
        Console.Write("Ingrese el número de cursos: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la mensualidad: ");
        mensualidad = double.Parse(Console.ReadLine());
    }

    // Función para registrar las notas y los créditos, y calcular el promedio ponderado
    public void RegistroNotaCredito()
    {
        double sumaNotasPorCreditos = 0;
        int sumaCreditos = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese la nota del curso " + (i + 1) + ": ");
            double nota = double.Parse(Console.ReadLine());

            Console.Write("Ingrese los créditos del curso " + (i + 1) + ": ");
            int creditos = int.Parse(Console.ReadLine());

            sumaNotasPorCreditos += nota * creditos;
            sumaCreditos += creditos;
        }

        // Calcular el promedio ponderado
        promedioPonderado = sumaNotasPorCreditos / sumaCreditos;
    }

    // Función para imprimir el promedio ponderado con dos decimales
    public void ImprimePromedio()
    {
        double promedioRedondeado = Math.Round(promedioPonderado * 100) / 100;
        Console.WriteLine("El promedio ponderado es: " + promedioRedondeado);
    }

    // Función para verificar si el promedio ponderado es mayor o igual a 12
    public void VerificaPromedio()
    {
        if (promedioPonderado >= 12)
        {
            Console.WriteLine("El alumno está aprobado.");
        }
        else
        {
            Console.WriteLine("El alumno está desaprobado.");
        }
    }

    // Función para verificar los descuentos según el promedio ponderado
    public void VerificaDescuentos()
    {
        double descuento = 0;

        if (promedioPonderado >= 19)
        {
            descuento = 0.20; // 20% de descuento
        }
        else if (promedioPonderado >= 18)
        {
            descuento = 0.10; // 10% de descuento
        }
        else if (promedioPonderado >= 17)
        {
            descuento = 0.05; // 5% de descuento
        }
        else if (promedioPonderado < 17)
        {
            descuento = 0; // Sin descuento
        }

        double totalAPagar = mensualidad - (mensualidad * descuento);
        double totalRedondeado = Math.Round(totalAPagar * 100) / 100;
        Console.WriteLine("El descuento aplicado es: " + (descuento * 100) + "%");
        Console.WriteLine("El total a pagar es: " + totalRedondeado);
        Console.ReadKey();
    }
}
