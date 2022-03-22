using System;

namespace vetorDeCarros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Oi cara, boa tarde ... digita por favor até três carros que não sai do seu coração");

            string palavras = Console.ReadLine();
            string[] P = palavras.Split(' ');
            string a = P[0];
            string b = P[1];
            string c = P[2];

            Console.WriteLine("Os carros que não sai do seu coração são incriveis !!!");
            Console.WriteLine("Vamos ver agora quais são os carros que não sai da sua cabeça agora.");
            Console.WriteLine("Atenção, atenção, que rufem os tambores");
            Console.WriteLine("E os carros são ;");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("Que carro incrivel o " + a);
            Console.WriteLine("Otimo gosto, fantatsico o " + b);
            Console.WriteLine("Ótimo gosto cara, é perfeito o carro " + c);
            Console.WriteLine("Até mais cara !");
        }
    }
}