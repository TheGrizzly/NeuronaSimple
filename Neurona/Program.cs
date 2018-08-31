using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurona
{
    class Program
    {

        static bool escalon(int w1, int w2, int b, int l1, int l2)
        {
            int res = (l1 * w1) + (l2 * w2) + ((-1) * b);
            if (l1 == 1 && l2 == 1)
                if (res > 0)
                    return true;
                else
                    return false;
            else
                if (res <= 0)
                    return true;
                else
                    return false;
        }

        static void Main(string[] args)
        {
            long contador = 1;
            int w1, w2, b;
            bool done = false;
            bool reset = false;
            Random rnd = new Random();
            w1 = rnd.Next(-100, 100);
            w2 = rnd.Next(-100, 100);
            b = rnd.Next(-100, 100);
            while (!done)
            {
                if (!escalon(w1, w2, b, 0, 0))
                    reset = true;
                if (!escalon(w1, w2, b, 0, 1))
                    reset = true;
                if (!escalon(w1, w2, b, 1, 0))
                    reset = true;
                if (!escalon(w1, w2, b, 1, 1))
                    reset = true;

                if (reset)
                {
                    contador++;
                    w1 = rnd.Next(-100, 100);
                    w2 = rnd.Next(-100, 100);
                    b = rnd.Next(-100, 100);
                    reset = false;
                }
                else
                {
                    done = true;
                }
            }
            Console.WriteLine("El numero de iteraciones fue: "+contador.ToString());
            Console.WriteLine("Los valores Aleatorios son:");
            Console.WriteLine("  W1: " + w1.ToString());
            Console.WriteLine("  W2: " + w2.ToString());
            Console.WriteLine("   B: " + b.ToString());
            Console.ReadLine();
        }
    }
}
