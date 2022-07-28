using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseJuanJose1
{
    public class Menu
    {
      
        public static void Option1()
        {
            Console.WriteLine("Ha elegido la opcion 1. Tendra que ingresar 3 numeros y obtendra su suma");
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero");
                int num3 = int.Parse(Console.ReadLine());


                int suma = num1 + num2 + num3;
                Console.WriteLine("La suma de los numeros ingresados es : " + suma);
            }

            catch (Exception ex)
            {
                Console.Write("Debe ser un numero");
            }

        }

        public static void Option2()
        {
            //Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y
            //mostrar por pantalla el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>
            try
            {
                Console.WriteLine("Ha escogido la opcion dos. Ingrese su nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese una ciudad");
                string ciudad = Console.ReadLine();
                Console.WriteLine("hola " + nombre + ". Bienvenido a " + ciudad);
            }
            catch (Exception ex)
            {
                Console.WriteLine("deben ser letras");
            }

        }

        public static void Option3()
        {
            //Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y tienes » <años> » años»
            Console.WriteLine("Ha escogido la opcion 3. Ingrese su nombre ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            string edad = Console.ReadLine();
            Console.WriteLine("Te llamas " + nombre + " y tienes" + edad + " anios");
        }

        public static void Option4()
        {
            //Pedir dos números al usuario por teclado y decir que número es el mayor.
            Console.WriteLine("Has elegido la opcion 4. Ingrese dos numeros para ver cual es el mayor");
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                int num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine("El numero mayor es " + num1);
                }
                else Console.WriteLine("El numero mayor es " + num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("deben ser numeros");
            }
        }

        public  static void Option5()
        {
            //Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo
            Console.WriteLine("Ha elegido la opcion cinco. Ingrese dia de la semana");

            string dia = Console.ReadLine();
            string fin = dia.Trim().ToLower();
            if (fin == "sabado" || fin == "domingo")
            {
                Console.WriteLine("Es fin de semana");
            }
            else Console.WriteLine("No es fin de semana");

        }

        public static void Option6()
        {
            //Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar
            //(efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)
            try
            {
                Console.WriteLine("Ha elegido la opcion 6. Ingrese un precio");
                int precio = int.Parse(Console.ReadLine());
                if (precio > 0)
                {
                    Console.WriteLine("La forma de pago es mediante tarjeta? (Ingrese si o no)");
                    string FormaPago = Console.ReadLine();
                    string verificar = FormaPago.Trim().ToLower();
                    if (verificar == "si")
                    {
                        Console.WriteLine("Ingrese el numero de tarjeta");
                    }
                    else Console.WriteLine("Debe pagar con tarjeta");
                }
                else Console.WriteLine("Debe ser positivo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("El precio debe ser un numero");
            }
        }

        public static void Option7()
        {
            //Recorre los números del 1 al 100. Usa un bucle for.

            Console.WriteLine("Ha elegido la opcion7. Se le mostraran los numeros del 1 al 100");
            int i;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Option8()
        {
            // Recorre los números del 1 al 100. Usa un bucle while.
            Console.WriteLine("Ha elegido la opcion 8. Se le mostrara los numeros del 1 al 100");

            int c = 0;
            while (c <= 100)
            {
                Console.WriteLine(c);
                c++;
               
            }
        }
        public static void Option9()
        {
            //Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras
            Console.WriteLine("Has elegido la opcion 9. Se mostraran los numeros pares en el rango del 1 al 100");
            int par=0;
            int i;
            for ( i = 1; i <=100 ; i++)
            {
                if (i%2==0)
                {
                    par+=i;
                    Console.WriteLine(i);
                }
            }
        }

        public static void Option10()
        {
            //Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
            int par = 0;
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3==0)
                {
                    par += i;
                    
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

    }
}
