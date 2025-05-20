using System;

public class Pesokg
{
    public double RecibirPeso()
    {
        Console.WriteLine("=== CONVERSOR DE PESOS ===");
        Console.WriteLine("Escribe el peso en kilogramos:");

        string entrada = Console.ReadLine();

        // Intenta convertir la entrada a número
        bool esNumero = double.TryParse(entrada, out double pesoKg);

        if (!esNumero)
        {
            Console.WriteLine("Valor no válido. Debes ingresar solo números.");
            return -1; // Valor especial para indicar error
        }

        return pesoKg;
    }
}

public class OperacionEjecutar
{
    public void EjecutarOperacion(double pesoKg)
    {
        double libras = pesoKg * 2.20462;
        Console.WriteLine("El peso en libras es: " + libras);
    }
}

class Program
{
    static void Main()
    {
        Pesokg peso = new Pesokg();
        double resultado = peso.RecibirPeso();

        if (resultado != -1)
        {
            OperacionEjecutar operacion = new OperacionEjecutar();
            operacion.EjecutarOperacion(resultado);
        }
    }
}
