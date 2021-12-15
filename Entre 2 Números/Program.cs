using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entre_2_Números
{
    class Program
    {
        static void Main(string[] args)
        {
            int Número1;
            int Número2;
            int NúmeroMayor;
            int NúmeroMenor;


            Console.Write("Ingrese el Número 1 por favor: ");
            Número1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Número 2 por favor: ");
            Número2 = int.Parse(Console.ReadLine());

            if(Número1 > Número2)
            {
                NúmeroMayor = Número1;
                NúmeroMenor = Número2;
            }
            else
            {
                NúmeroMayor = Número2;
                NúmeroMenor = Número1;
            }
            while(NúmeroMenor + 1 < NúmeroMayor)
            {
                NúmeroMenor = NúmeroMenor + 1;
                Console.WriteLine("{0}", NúmeroMenor);
            }
            Console.Read();
        }
    }
}
