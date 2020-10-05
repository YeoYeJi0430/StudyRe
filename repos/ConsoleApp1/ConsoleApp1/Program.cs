using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat
    {
        public string name;
        public string color;

        public Cat (string _name, string _color)
        {
            name = _name;
            color = _color;
        }
        public void Meow(int count)
        {
            for(int i=0; i<count; i++)
            {
                System.Console.WriteLine("야옹!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat 하양이 = new Cat("하양이", "하얀색");
            하양이.Meow(3);
            Console.WriteLine($"고양이 이름은 {하양이.name}이고 색깔은 {하양이.color}이다.");
        }
    }
}
