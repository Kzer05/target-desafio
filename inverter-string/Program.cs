using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine() ?? "";

        string textoInvertido = InverterTexto(texto);

        Console.WriteLine("String invertida: " + textoInvertido);
    }

    static string InverterTexto(string texto)
    {
        char[] letrasDoTexto = texto.ToCharArray();
        char[] letrasDoTextoInvertido = new char[letrasDoTexto.Length];

        for (int i = 0; i < letrasDoTexto.Length; i++)
        {
            letrasDoTextoInvertido[i] = letrasDoTexto[letrasDoTexto.Length - 1 - i];
        }

        string textoInvertido = new string(letrasDoTextoInvertido);

        return textoInvertido;
    }
}
