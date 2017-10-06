using System;
using CorretorLib;

namespace CorretorOrtografico
{
    class Program
    {
        static void Main(string[] args)
        {

            var palavra = "caza";
            var resposta = CorretorManager.Verificar(palavra);

            Console.WriteLine("A palavra está " + (resposta.IsCorreto ? "Certa" : "errada"));
            Console.WriteLine("Voce quis dizer:" + String.Join(" ", resposta.Sugestoes));

            Console.ReadKey();
        }
    }
}
