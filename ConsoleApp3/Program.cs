using System;

namespace pizza
{
    class Program 
    {


        static void Main(string[] args) 
        {

            Pizza pizza1 = new Pizza("Маргарита", 320, ",белый", 25, "нет" );
            Pizza pizza2 = new Pizza("Пеперони", 650, "красный", 32, "да");
            Pizza pizza3 = new Pizza("Барбекю", 580, "красный", 32, "нет");
            Pizza pizza4 = new Pizza("Сырная", 390, "белый", 25, "да");
            Pizza pizza5 = new Pizza("Итальянская", 470, "красный", 32, "нет");



            pizza1.Print();
            pizza2.Print();
            pizza3.Print();
            pizza4.Print();
            pizza5.Print();


            
        }
    }
}
