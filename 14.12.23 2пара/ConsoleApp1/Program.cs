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

            //2

            //Avto avto = new Avto();
            //avto.Brand = "Mercedes-Benz";
            //avto.Color = "Черный";
            //avto.Skor = 365;

            //Console.WriteLine(avto.ShowInfo());




            //3

            Computer computer = new Computer();
            computer.Model= "Samsung";
            computer.Ram = 33;
            computer.Hdd = 1999;

            Console.WriteLine(computer.ShowInfo());


            Console.ReadKey();

        }
    }
}
