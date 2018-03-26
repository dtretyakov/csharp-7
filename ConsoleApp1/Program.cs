using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void PrintStars(string s)
        {
            if (int.TryParse(s, out var i)) { Console.WriteLine(new string('*', i)); }
            else { Console.WriteLine("No stars!"); }
        }

        public void PrintStars2(object o)
        {
            if (o is null) return;
            if (!(o is int i)) return;
            Console.WriteLine(new string('*', i));

            switch (o)
            {
                case int c:
                    Console.WriteLine($"int {c}");
                    break;
                case long s:
                    Console.WriteLine($"long {s}");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(o));
            }

            var x = 2;
            if (x < 0) throw new ArgumentException("Не надо негатива!", nameof(x));
            fun(x);

            int fun(int z)
            {
                return z + 1;
            }
        }
    }
    
    public class MyClass {
        public string Hello () {
            return "Hello";
        }
    }
}
