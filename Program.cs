using System;

namespace ExercicioPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var programador = new Programador();
            programador.Nome = "Jefferson";
            programador.Cargo = "Programador Pleno";
            programador.Linguagem = "C#";

            var programadorClone = (Programador)programador.Clone();
            programadorClone.Nome = "Sueli";
            programadorClone.Cargo = "Programador Júnior";

            Console.WriteLine(programador);
            Console.WriteLine(programadorClone);

            var engenheiro = new Engenheiro();
            engenheiro.Nome = "Mario";
            engenheiro.Cargo = "Engenheiro Mecânico";
            engenheiro.Especialidade = "Motores";

            var engenheiroClone = (Engenheiro)engenheiro.Clone();
            engenheiroClone.Nome = "Amanda";
            engenheiroClone.Especialidade = "Fluidos";

            Console.WriteLine(engenheiro);
            Console.WriteLine(engenheiroClone);
        }
    }
}
