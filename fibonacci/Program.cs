using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int primeiroNumSeq = 0;
        int segundoNumSeq = 1;

        Console.WriteLine("Digite um número: ");
        
        while (true)
        {
            try
            {
                numero = int.Parse(Console.ReadLine()); // Número desejado
                break;
            }
            catch
            {
                Console.WriteLine("Digite um valor valido: ");
            }
        }


        // Verificando se o número pertence à sequência de Fibonacci
        while (segundoNumSeq < numero)
        {
            int temp = segundoNumSeq;
            segundoNumSeq = primeiroNumSeq + segundoNumSeq;
            primeiroNumSeq = temp;
        }

        // Verificando se o número pertence à sequência
        if (segundoNumSeq == numero)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }
}
