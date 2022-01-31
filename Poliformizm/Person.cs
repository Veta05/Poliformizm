using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    abstract class Person
    {
        string name;   //Фамилия
        public void SetName()        // Метод запроса фамилии
        { Console.Write("Lastname : "); name = Console.ReadLine(); }
        public void GetName()      // Метод вывода фамилии 
        { Console.WriteLine(" Mr " + name); }
        //реализация следующих методов будет определена в потомках      
        public abstract void SetData();   // Метод запроса данных
        public abstract bool SetStat();   //  Метод определения выдающейся личности
    }
    class Student : Person   //производный класс  Студент
    {
        double ball;     //средний балл студента
        public override void SetData()     // Метод запроса данных по студенту
        {
            Console.WriteLine("Student: ");
            base.SetName();    // вызов метода базового класса Person
            Console.Write("Avarage mark: ");
            string s;
            s = Console.ReadLine();
            ball = Convert.ToDouble(s);
        }
        public override bool SetStat()   // Метод определения выдающегося студента 
        { if (ball > 4.8) { base.GetName(); Console.Write("Avarage mark=" + ball); return true; } else return false; }
    }
    class Teach : Person    //производный класс  Преподаватель
    {
        int kol;          // количество публикаций преподавателя
        public override void SetData()   // Метод запроса данных по преподавателю
        {
            Console.WriteLine("Teacher");
            base.SetName();     // вызов метода базового класса Person
            Console.Write("Number of publications:");
            string s;
            s = Console.ReadLine();
            kol = Convert.ToInt32(s);
        }
        public override bool SetStat()  // Метод определения выдающегося преподавателя 
        { if (kol > 10) { base.GetName(); Console.Write("Number of publications=" + kol); return true; } else return false; }
    }
}

