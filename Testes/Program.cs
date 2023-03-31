public class Program
{
    static void Main(string[] args)
    {

    }
    public static double CalculaMedia(List<int> numeros)
    {
        if (numeros.Count == 0)
        {
            return 0.0;
        }
        else
        {
            int soma = numeros.Sum();
            return (double)soma / numeros.Count;
        }
    }

    public static bool EstaOrdenada(List<int> lista)
    {
        for (int i = 0; i < lista.Count - 1; i++)
        {
            if (lista[i] > lista[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    public static int Fatorial(int num)
    {
        int resultado = 1;

        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
        }

        Console.WriteLine(resultado);
        return resultado;
    }

    public static double ConverteTemperatura(double temperaturaCelsius)
    {
        double temperaturaFahrenheit = (temperaturaCelsius * 1.8) + 32;
        return temperaturaFahrenheit;
    }

    public static bool EPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool ListaOrdenada(List<int> numeros)
    {
        bool crescente = true;
        bool decrescente = true;

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            if (numeros[i] > numeros[i + 1])
            {
                crescente = false;
            }

            if (numeros[i] < numeros[i + 1])
            {
                decrescente = false;
            }
        }

        return crescente || decrescente;
    }
}

