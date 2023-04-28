using System;

namespace Exceptional_situations
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой, создайте класс Calculator.В теле класса создайте четыре
        //метода для арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div
        //– деление). Метод деления должен делать проверку деления на ноль, если проверка не
        //проходит, сгенерировать исключение.Пользователь вводит значения, над которыми хочет
        //произвести операцию и выбрать саму операцию.При возникновении ошибок должны
        //выбрасываться исключения.
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); 
            try{
                Console.Write("Введите число 1: ");
                calculator.Number1 = int.Parse(Console.ReadLine());
                Console.Write("Введите число 2: ");
                calculator.Number2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
            Console.Write("1)сложение 2)вычитание 3)умножение 4)деление" + "\nВведите число: ");
            int Function = int.Parse(Console.ReadLine());
            switch (Function)
            {
                case 1:
                    calculator.Add();
                    break;
                case 2:
                    calculator.Sub();
                    break;
                case 3:
                    calculator.Mul();
                    break;
                case 4:
                    calculator.Div();
                    break;
            }
        }
    }
    class Calculator
    {
        public int Number1;
        public int Number2;
        private int result;
        public void Add(){
            result = Number1 + Number2;
            Console.WriteLine(result);
        }
        public void Sub(){
            Console.Write("Введите какое число вы хотите поделить 1 или 2: ");
            int Function = int.Parse(Console.ReadLine());
            switch (Function){
                case 1:
                    result = Number2 - Number1;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = Number1 - Number2;
                    Console.WriteLine(result);
                    break;
            }
        }
        public void Mul(){
            result = Number1 * Number2;
            Console.WriteLine(result);
        }
        public void Div(){
            Console.Write("Введите на какое число вы хотите поделить 1 или 2: ");
            int Function = int.Parse(Console.ReadLine());
            if (Function == 1){
                try{
                    result = Number1 / Number2;
                    Console.WriteLine(result);
                }
                catch (Exception exception){
                    Console.WriteLine(exception.Message);
                }
            }
            else if (Function == 2){
                try{
                    result = Number2 / Number1;
                    Console.WriteLine(result);
                }
                catch (Exception exception){
                    Console.WriteLine(exception.Message);
                }
            }
            
            
        }
    }
}
