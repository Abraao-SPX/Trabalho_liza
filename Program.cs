using System;
using System.Collections.Generic;

namespace PecaBonusTextoPuro
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Bonus { get; set; }
        public List<Funcionario> Subordinados { get; set; } = new List<Funcionario>();

        public Funcionario(string nome, double bonusBase = 0)
        {
            Nome = nome;
            Bonus = bonusBase;
        }

        public void AdicionarSubordinado(Funcionario func)
        {
            Subordinados.Add(func);
        }

        public double CalcularBonus()
        {
            if (Subordinados.Count == 0)
            {
                Console.WriteLine($"{Nome} diz: Sou base. Meu valor e {Bonus}");
                return Bonus;
            }

            double soma = 0;
            foreach (var sub in Subordinados)
            {
                soma += sub.CalcularBonus();
            }
            Bonus = soma / Subordinados.Count;

            Console.WriteLine($"{Nome} diz: Terminei. Minha media deu {Bonus}");
            return Bonus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var p3 = new Funcionario("Personagem 3", 1000);
            var p4 = new Funcionario("Personagem 4", 2000);

            var p2 = new Funcionario("Personagem 2");
            p2.AdicionarSubordinado(p3);
            p2.AdicionarSubordinado(p4);

            var p5 = new Funcionario("Personagem 5", 3500);

            var p1 = new Funcionario("Personagem 1");
            p1.AdicionarSubordinado(p2);
            p1.AdicionarSubordinado(p5);

            p1.CalcularBonus();

            Console.ReadKey();
        }
    }
}