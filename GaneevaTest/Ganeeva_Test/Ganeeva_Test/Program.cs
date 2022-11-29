using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;
namespace Ganeeva_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp.GetInspector();//данный метод возвращает ФИО главного инспектора
            Console.WriteLine();
            FunctionInsp.GetСarInspection(); //возвращает название автоинспекции
            Console.WriteLine();
            FunctionInsp.SetInspector(); //изменяет ФИО главного инспектора 
            Console.WriteLine();
            FunctionInsp.GenerateNumber();//генерация номера
            FunctionInsp.GetWorker(); //вывод списка всех сотрудников
            Console.WriteLine();
            FunctionInsp.AddWorker();//добавление нового сотрудника в список
            Console.WriteLine();
            
        
          
        }
    }
}
