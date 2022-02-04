using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string b = a.ToString();

            float c = 50.0F;

            byte d = 200;
            int e = d; // bilinçli dönüşüm
            d = (byte)a; // bilinçsiz dönüşüm
            c = e; // bilinçli

            string f = "b degişkeninin string değeri: " + b;

        }
    }
}
