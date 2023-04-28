using System;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой, создайте структуру с именем Price, содержащую следующие
        //поля: название товара, название магазина, в котором продается товар, тоимость товара в
        //гривнах.Написать логику, которая будет выполнять следующие действия: 1) ввод с клавиатуры
        //данных в массив, состоящий из двух элементов типа Price(записи должны быть упорядочены в
        //алфавитном порядке по названиям магазинов); 2) вывод на экран информации о товарах,
        //продающихся в магазине, название которого введено с клавиатуры(если такого магазина нет,
        //вывести исключение).
        static void Main(string[] args)
        {
            Console.WriteLine("Магазины");
            PriceS priceS = new PriceS();
            priceS.FillingShop();
        }
    }
    struct PriceS
{
        public void FillingShop() {
            string[] PriceS = new string[6] { "Rozetka", "Пенал", "Zara", "Кофта", "Fora", "Хлеб", };
            int[] PriseP = new int[3] { 10, 16, 8};
            Console.WriteLine("Меню");
            for (int i = 0; i < PriceS.Length; i++){ 
                Console.WriteLine(PriceS[i] + " - Название магазина");
                Console.WriteLine(PriceS[i + 1] + " - Название товара ");
                if (i != 3 && i < 3){
                    Console.WriteLine(PriseP[i] + " - Цена товара");
                } 
                i++;
            }
            Console.Write("Введите магазиг какой вас интересует: ");
            string ShopName = Console.ReadLine();
            try{
                for (int i = 0; i < PriceS.Length; i++){
                    if (PriceS[i] == ShopName)
                    {
                        Console.WriteLine(PriceS[i ] + " - Название магазина");
                        Console.WriteLine(PriceS[i + 1] + " - Название товара ");
                        if (i != 3 && i < 3){
                            Console.WriteLine(PriseP[i] + " - Цена товара");
                        }
                    }
                    else
                    {
                        if (PriceS[i] != ShopName)
                        {
                            Console.WriteLine("Такого магазина нету !");
                            break;
                        }
                    }
                }
            }
            catch (Exception e ){
                Console.WriteLine(e.Message);
            }
        }
    }
}
