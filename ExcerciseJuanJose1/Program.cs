using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseJuanJose1
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el método main principal,  realizar un menú para que al ejecutar la consola, primeramente el usuario
            //ingrese el número del ejercicio que se desea ejecutar.

            Console.WriteLine("Ingrese el numero del ejercicio que desea ejecutar");
            string option = Console.ReadLine();
            
            
            switch (option)
            {
                case "1": Menu.Option1(); break;
                case "2": Menu.Option2(); break;
                case "3": Menu.Option3(); break;
                case "4": Menu.Option4(); break;
                case "5": Menu.Option5(); break;
                case "6": Menu.Option6(); break;
                case "7": Menu.Option7(); break;
                case "8": Menu.Option8();  break;
                case "9": Menu.Option9(); break;
                case "10": Menu.Option10(); break;
                default : Console.WriteLine("debe ser un numero"); break;
            }

            Console.ReadLine();
        }
       

      
    }
}
