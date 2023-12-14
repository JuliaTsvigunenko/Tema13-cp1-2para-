using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Avto
    {

        /// <summary>
        /// Поле марки автомобиля
        /// </summary>
        private string brand;

        /// <summary>
        /// Поле цвета автомобиля
        /// </summary>
        private string color;

        /// <summary>
        /// Поле скорости автомобиля
        /// </summary>
        private int skor;

       
       
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
                
        }


        public string Color
        {
            get { return color; }
            set {color = value; }

        }

        public int Skor
        {
            get 
            {
                return skor;
            }
            set { skor =  (value > 20) & (value < 120) ? value : 0; }

        }



        public Avto()
        {

        }

        public Avto(string brand, string color, int skor)
        {
            this.Brand = brand;
            this.Color = color;
            this.Skor = skor;
        }




        //public double Skor { get => skor; set => skor = value; }
        //public string Color { get => color; set => color = value; }
        //public string Brand { get => brand; set => brand = value; }

        public string ShowInfo()
        {
            return $"Марка авто - {brand}\nЦвет авто - {color}\nСкорость авто - {skor} ";
        }







    }
}
