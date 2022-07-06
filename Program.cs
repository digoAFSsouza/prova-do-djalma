using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_do_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercíco: 1 ");

            Console.WriteLine("digite seu nome: ");
            string nome;
            nome = Console.ReadLine();

            Console.WriteLine("digite a nota do trabalho: ");
            double trabalho;
            trabalho = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nescreva a nota da 1º prova: ");
            double prova1;
            prova1 = double.Parse(Console.ReadLine());

            Console.Write("\nescreva a nota da 2º prova: ");
            double prova2;
            prova2 = double.Parse(Console.ReadLine());

            double media;
            media = (trabalho + prova1 + prova2) / 3;

            if (media >= 8.5)
            {
                Console.WriteLine(nome + " conceguiu conceito A ");
            }

            else if (media >= 7)
            {
                Console.WriteLine(nome + " conceguiu conceito B ");
            }

            else if (media >= 6)
            {
                Console.WriteLine(nome + " conceguiu conceito C ");
            }

            else if (media > 0)
            {
                Console.WriteLine(nome + " conceguiu conceito D ");
            }

            else if (media == 0)
            {
                Console.WriteLine(nome + " conceguiu conceito F ");
            }
            Console.WriteLine("exercicio: 2");

            Console.WriteLine("cidades com os seus códigos ");
            Console.WriteLine("1 – Atibaia");
            Console.WriteLine("2 – Bragança Paulista");
            Console.WriteLine("3 – Mairiporã");
            Console.WriteLine("4 – Nazaré");
            Console.WriteLine("5 – Terra Preta");
            Console.WriteLine("6 – Extrema");
            Console.WriteLine("7 – Vargem");

            Console.Write("digite o código de uma cidade : ");
            int cidade = Convert.ToInt32(Console.ReadLine());

            String cidadeExtenso = null;

            switch (cidade)
            {
                case 1:
                    cidadeExtenso = "Atibaia";
                    break;

                case 2:
                    cidadeExtenso = "Bragança Paulista";
                    break;

                case 3:
                    cidadeExtenso = "Mairiporã";
                    break;

                case 4:
                    cidadeExtenso = "Nazaré";
                    break;

                case 5:
                    cidadeExtenso = "Terra Preta";
                    break;

                case 6:
                    cidadeExtenso = "Extrema";
                    break;

                case 7:
                    cidadeExtenso = "Vargem";
                    break;

            }

            Console.Write("\ndigite uma data: ");

            var DataEscolhida = Convert.ToDateTime(Console.ReadLine());

            int dia = DataEscolhida.Day;

            int mes = DataEscolhida.Month;

            int ano = DataEscolhida.Year;

            String MesExtenso = null;

            switch (mes)
            {
                case 1:
                    MesExtenso = "Janeiro";
                    break;

                case 2:
                    MesExtenso = "Fevereiro";
                    break;

                case 3:
                    MesExtenso = "Março";
                    break;

                case 4:
                    MesExtenso = "Abril";
                    break;

                case 5:
                    MesExtenso = "Maio";
                    break;

                case 6:
                    MesExtenso = "junho";
                    break;

                case 7:
                    MesExtenso = "Julho";
                    break;

                case 8:
                    MesExtenso = "Agosto";
                    break;

                case 9:
                    MesExtenso = "Setembro";
                    break;

                case 10:
                    MesExtenso = "Outubro";
                    break;

                case 11:
                    MesExtenso = "Novembro";
                    break;

                case 12:
                    MesExtenso = "Dezembro";
                    break;
            }

            Console.WriteLine(cidadeExtenso + ", " + dia + " de " + MesExtenso + " de " + ano);
        }
    }
}
