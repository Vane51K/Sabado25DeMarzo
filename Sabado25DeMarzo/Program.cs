using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabado25DeMarzo
{
    class Program
    {
        static void adivinanza(int hola)
        {
            const int oportunidades = 4;
            int numerosCPU, numerosUsuario;
            byte intentos, banderaControl;
            string linea;
            //generar numeros de 1 al 20 unicamente.

            Random ran = new Random();
            do
            {
                numerosCPU = Convert.ToInt32(ran.Next(100));
            } while (!(((numerosCPU >= 1) & (numerosCPU <= 20))));

            //Proceso
            intentos = 1;
            banderaControl = 0;

            do
            {
                Console.WriteLine("Estoy Pensando En Un Número, Cúal Será? ");
                linea = Console.ReadLine();
                numerosUsuario = Convert.ToInt32(linea);

                if (numerosCPU == numerosUsuario)
                {
                    Console.WriteLine("Adivinaste!!!");
                }
                else
                {
                    if ((numerosUsuario > numerosCPU))
                    {
                        Console.WriteLine("Número muy grande :(");
                    }
                    else
                    {
                        Console.WriteLine("Número muy pequeño :(");
                    }
                    intentos++;
                }

            } while (((intentos <= oportunidades) & (banderaControl == 0)));

            if (banderaControl == 0)
            {
                Console.WriteLine("El número es:" + numerosCPU);
            }
            Console.ReadLine();
        }


        static void Mayormenor(int hola)
        {
            int mayor = 0;
            int numeros = 0;
            int menor = 10;
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                numeros = random.Next(10);
                Console.WriteLine(numeros);
                if (numeros > mayor)
                {
                    mayor = numeros;
                }
                if (numeros < menor)
                {
                    menor = numeros;
                }
            }

            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
            Console.ReadLine();
        }
        static void catcher(int hola2)
        {
            int cantidad = 0;
            Console.WriteLine("Ingrese una Cantidad: ");
            try
            {
                cantidad = int.Parse(Console.ReadLine());
            } catch (FormatException fex)
            {
                Console.WriteLine("Ingrese mal el numero entero:" + fex.Message);
            } catch (Exception ex)
            {
                Console.WriteLine("Hay un error de otro tipo" + ex.Message);
            }
            if (cantidad > 0)
            {
                Console.WriteLine("Cantidad ingresada: " + cantidad);
            }
        }
        static void ejemploArreglo(int hola3)
        {
            //int[] numero = new int[7];
            //int suma = 0;
            //numero[0] = 45;
            //numero[1] = 50;
            //numero[2] = 60;
            //numero[3] = 70;
            //numero[4] = 86;
            //numero[5] = 92;
            //numero[6] = 69;
            //int elementos = numero.Length;

            int elementos = 10;
            string[] nombres = new string[elementos];
            nombres[0] = "Maria";
            nombres[1] = "Juan";
            nombres[2] = "Pedro";
            nombres[3] = "Pablo";
            nombres[4] = "Mario";
            nombres[5] = "Luis";
            nombres[6] = "Felipe";
            nombres[7] = "Alfredo";
            nombres[8] = "Bartolo";
            nombres[9] = "Alex";
            nombres[10] = "Fernanda";

            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine(nombres[i]);
                Random rnd = new Random();
                int ganador1 = rnd.Next(0, 10);
                int ganador2 = rnd.Next(0, 10); 
                while (ganador2 == ganador1) 
                {
                    ganador2 = rnd.Next(0, 10);
                }
                string ganador01 = nombres[ganador1];
                string ganador02 = nombres[ganador2];

                Console.WriteLine("Ganaste una pierna de CERDO: " + ganador1 + "Ganaste un CERDO SIN PIERNA" +ganador2);
            
            //suma = suma + numero[i];
            //Console.WriteLine(numero[i]);
        } Console.ReadLine();
            //Console.WriteLine("Sumatoria =" + suma);
            //Console.WriteLine("El promedio es=" + suma / elementos);
        } 
     
    }
}