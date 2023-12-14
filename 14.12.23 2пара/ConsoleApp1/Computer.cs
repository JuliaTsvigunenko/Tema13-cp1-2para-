using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer
    {

        private string model;
        private int ram;
        private int hdd;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ram
        {
            get
            { 
                return ram;
            }

            set { ram = (value > 2) & (value < 32) ? value : 0; }
        }



        public int Hdd
        {
            get 
            { 
                return hdd;
            }

            set { hdd = (value>200) & (value<2000)?value:0; }
        }


        public Computer()
        {

        }

        public Computer (string model, int ram, int hdd)
        {
            this.Model = model;
            this.Ram = ram;
            this.Hdd = hdd;
        }


        public string ShowInfo()
        {
            return $"Модель - {model}\nОЗУ - {ram}\nЖесткий диск- {hdd} ";
        }



    }
}
