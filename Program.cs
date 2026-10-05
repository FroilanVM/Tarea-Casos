using System;

class Program
{
    static double ObtenerNota()
    {
        double nota;

        Console.Write("Ingrese la nota final: ");

        while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
        {
            Console.WriteLine("Error: ingrese una nota válida entre 0 y 100.");
            Console.Write("Ingrese nuevamente la nota: ");
        }

        return nota;
    }

    static void MostrarResultado(double nota)
    {
        if (nota >= 70)
        {
            Console.WriteLine("El estudiante aprobó.");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó.");
        }
    }

    static void Main(string[] args)
    {
        double nota = ObtenerNota();

        MostrarResultado(nota);
    }
}