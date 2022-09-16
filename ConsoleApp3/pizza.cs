using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    public class Pizza
    {

        public string Name { get; set; } //Название пиццы
        public int Price { get; set; }// Цена пиццы
        public string Sauce { get; set; }// На каком соусе пицца, красном или белом к примеру
        public int Diameter { get; set; }// Диаметр пиццы к примеру 25 32 и тд.
        public string DoubleCheese { get; set; } //Двойная порция пиццы


        public Pizza(string name, int price, string sauce, int diametr, string doublecheese)
        {
            Name = name;
            Price = price;
            Sauce = sauce;
            Diameter = diametr;
            DoubleCheese = doublecheese;
        }

        public void Print()
        {
            Console.WriteLine("pizza = {0}, Price = {1} рублей, Sauce = {2}, Diametr = {3} см, DoubleCheese = {4} ", Name, Price, Sauce, Diameter, DoubleCheese);
           
        }

    }
}
