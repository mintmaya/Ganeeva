using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganeeva_InspectorLib
{
    public class FunctionInsp

    {
        public static string fullname = "Смельчак Кирилл Андреевич"; //переменная, хранящая имя главного инспектора
        public static string[] workers = new string[] { "Секачков Артур Тимофеевич", "Селяев Борис Николаевич", "Смирнов Константин Львович", "Смельчак Кирилл Андреевич" };//массив, в котором хранятся имена всех сотрудников
      public  static void GetInspector()
        {
            Console.WriteLine($"Главный инспектор – {fullname}");//вывод имени главного инспектора
        }
        public static void GetСarInspection()
        {
            Console.WriteLine("Название: Автоинспекция г. Чита");//вывод названия инспекции
        }
        public static void SetInspector()
        {
            for (int i = 0; i < workers.Length; i++) //цикл для перебора всех сотрудников
            {
                if (workers[i] != fullname) //если имя сотрудника не совпадает с именем инспектора, то действие пропускается
                {
                    continue;
                }
                else //если найден сотрудник с именем инспектора, то пользователь изменяет ФИО инспектора 
                {
                    Console.WriteLine("Измените имя глав. инспектора");
                    fullname = Console.ReadLine(); //изменение ФИО
                    Console.WriteLine($"Измененное имя инспектора: {fullname}");
                }
            }
        }
        public static void GenerateNumber()
        {
            const int code = 75; //номер региона
            Console.WriteLine("Ваш номер: ");
            Random rndNum = new Random();
           int number = rndNum.Next(100, 999); //генерация трехзначного числа, которое будет записано в номер
            Random randChar = new Random();
          char  symbol = (char)randChar.Next('А', 'Я' + 1);//генерация буквы, которая будет записана в номер
            Console.WriteLine($"{symbol}{number}_{code}"); //вывод сгенерированого номера
        }  

     
        public static void GetWorker()
        {
            Console.WriteLine("Cписок сотрудников:");
            for (int i = 0; i < workers.Length; i++) //вывод всех сотрудников с помоцью цикла
            {
                Console.WriteLine($"{i+1}.{workers[i]}");
            }
        }
       
        public static void AddWorker()
        {
            Console.WriteLine("Введите имя нового сотрудника");
            string newWorker = Console.ReadLine(); //ввод новых данных
            workers = workers.Concat(new string[] {newWorker}).ToArray(); //добавление нового сотрудника в список
            Console.WriteLine("Новый список сотрудников автоинспекции:");
            for (int i = 0; i < workers.Length; i++) //вывод нового списка сотрудников через цикл
            {
                Console.WriteLine($"{i + 1}.{workers[i]}");
            }
        }
    }

}
