using System;

namespace Pratica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            string nome = "Lucas";
            double valor = 12.3023234;
            double b1 = 21.8345;
            double b2 = 3;
            double b3 = 1.734;
            Console.WriteLine(nome);
            //2 CASAS DECIMAIS
            Console.WriteLine(valor.ToString("F2")); 
            Console.WriteLine(b1.ToString("F2"));
            Console.WriteLine(b2.ToString("F2"));
            Console.WriteLine(b3.ToString("F2"));
            
            Console.WriteLine("-------------");

            //Produto: COmputador
            //Preço: 2500
            //quantidade: 10
            //TOtal:

            int numero1, numero2 ,resultados;
            Console.Write("informe o valor -->");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("informe a quantidade -->");
            numero2 = int.Parse(Console.ReadLine());

            resultados = numero1 + numero2;
            Console.Write("o total vai ser de: " + resultados);
            Console.WriteLine();
            


            Console.WriteLine("-------------");
            
            //Introdução ao C#: 10
            //Criar projeto e Solução: 8,6
            //Enviar ao GTIHUB: 10

            double nota1 = 10;
            double nota2 = 8.6;
            double nota3 = 10;
            double media;
            
            String Nome = ("lucas");
            Console.WriteLine(Nome);

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A MEDIA É:");
            Console.WriteLine(media.ToString(("F2")));




            Console.WriteLine("-------------");
        }

    }
}
