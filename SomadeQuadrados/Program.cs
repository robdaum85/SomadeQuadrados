using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomadeQuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de Qua - avaliação de teste");

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };


            Func<List<int>, int> Qd = null;
            Qd =
                x =>
                (x.Count == 0) ? 0 : x.Last() * x.Last() + Qd(x.Take(x.Count - 1).ToList<int>());


            Func<List<int>, int> Qd2 =
                x =>
                x.Select(i => i * i).Sum();




            Func<Func<int, int, int>, List<int>, int> Qd3 = null;
            Qd3 =
                (a, c) =>
                (c.Count == 0) ? 0 : a(c.Last(), Qd3(a, c.Take(c.Count - 1).ToList<int>()));
            Func<int, int, int> Qd3S =
                (a, b) =>
                b + (a * a);


            var valor1 = Qd(list);
            var valor2 = Qd2(list);
            var valor3 = Qd3(Qd3S, list);

            Console.WriteLine("Abaixo segue o resultado dos valores ao quadrado");
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);


        }
    }

    }
