using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Application.
        //Создайте программу, в которой, создайте структуру с именем Worker(работник), содержащую
        //следующие поля: фамилия и инициалы работника, название занимаемой должности, год
        //поступления на работу.Написать логику, которая будет выполнять следующие действия: 1) ввод с
        //клавиатуры данных в массив, состоящий из пяти элементов типа Worker(записи должны быть
        //упорядочены по алфавиту); 2) сли значение года введено не в соответствующем формате выдает
        //исключение; 3) вывод на экран фамилии работника, стаж работы которого превышает введенное
        //значение.
        static void Main(string[] args)
        {
            WorkerTv workerTv = new WorkerTv();
            try{
                for (int i = 0; i < 5; i++){
                    Console.Write("Введите имя работника: ");
                    string NameM = Console.ReadLine();
                    Console.Write("Введите название занимаемой должности: ");
                    string PositionWorkerM = Console.ReadLine();
                    Console.Write("Введите год поступления на работу: ");
                    int JoinInM = int.Parse(Console.ReadLine());
                    workerTv.InPrint(NameM, PositionWorkerM, JoinInM,i);
                }
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
    struct WorkerTv{
        public void InPrint(string NameM,string PositionWorkerM,int JoinM,int g){
            string[] NameWork = new string[5];
            string[] PositionWorker = new string[5];
            int[] JoinWorker = new int[5] { 10, 6, 8, 9, 3 };
            for (int i = 0; i < NameWork.Length; i++){
                NameWork[i] = NameM;
            }
            for (int i = 0; i < PositionWorker.Length; i++){
                PositionWorker[i] = PositionWorkerM;
            }
            for (int i = 0; i < 1; i++){
                if (JoinWorker[g] < JoinM){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Инициалы - "+NameWork[g]+" Должность - "+PositionWorker[g]+" Поступление на работу - "+JoinWorker[g]);
                    Console.ResetColor();
                }
                else if (JoinWorker[g] >= JoinM){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Инициалы - "+NameWork[g]+" Должность - "+PositionWorker[g]+ 
                        " Стаж работы роботника не превышает введенное значение");
                    Console.ResetColor();
                }
            }
            
        }
            
        
    }
}
