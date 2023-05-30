using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UEstebanApesa
{
    public class Ejercicios
    {
        public static void Ejercicio1()
        {
            string[] respuesta = new string[3];
            int a = 0;
            string nombre = "";
            System.Console.WriteLine("Ingrese la fecha que sea año/ mes / dia ejemplo 120123");
            string Fecha = System.Console.ReadLine();


            for (int i = 0; i < Fecha.Length; i = i + 2)
            {

                respuesta[a] = Fecha.Substring(i, 2);
                a++;
            }

            string año = respuesta[0];
            string mes = respuesta[1];
            string dia = respuesta[2];

            if (mes == "00")
            {
                Console.WriteLine("Error");
            }
            else if (mes == "01")
            {
                nombre = "Enero";
                //DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
                //nombre = formatoFecha.GetMonthName(Convert.ToInt32(mes));

            }
            else if (mes == "02")
            {
                nombre = "Febrero";
            }
            else if (mes == "03")
            {
                nombre = "Marzo";
            }
            else if (mes == "04")
            {
                nombre = "Abril";
            }
            else if (mes == "05")
            {
                nombre = "Mayo";
            }
            else if (mes == "06")
            {
                nombre = "Junio";
            }
            else if (mes == "07")
            {
                nombre = "Julio";
            }
            else if (mes == "08")
            {
                nombre = "Agosto";
            }
            else if (mes == "09")
            {
                nombre = "Septiembre";
            }
            else if (mes == "10")
            {
                nombre = "Octubre";
            }
            else if (mes == "11")
            {
                nombre = "Noviembre";
            }
            else if (mes == "12")
            {
                nombre = "Diciembre";
            }
            //Console.WriteLine(dia + " " + nombreMes + " " + año);

            Console.WriteLine(dia + " " + nombre + " " + año);

            Console.ReadKey();
        }

        public static void Ejercicio2()
        {
            //decimal rest1 = 0, rest2 = 0, rest3 = 0;
            Console.WriteLine("ingrese el año que desea saber si es bisiesto o no");
            decimal año = int.Parse(Console.ReadLine());

            decimal rest1 = año % 100;
            decimal rest2 = año % 4;
            decimal rest3 = año % 400;

            if (rest1 == 0 & rest2 == 0 & rest3 > 1)
            {
                Console.WriteLine("El año SI es bisiesto ");
            }
            else
            {
                Console.WriteLine("El año NO es bisiesto ");
            }
            Console.ReadKey();
        }

        public static void Ejercicio3()
        {
            string tex = "";
            Console.WriteLine("ingrese el primer valor");
            decimal var1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer valor");
            decimal var2 = int.Parse(Console.ReadLine());

            decimal res = var1 % 2;
            decimal res1 = var2 % 2;

            if (res == 0 & res1 == 0)
            {
                tex = "los dos digitos Son pares";
            }
            else if (res == 1 & res1 == 1)
            {
                tex = "los dos digitos Son impares";
            }
            else if (res == 0 & res1 >= 1)
            {
                tex = "los primer digito es par y el segundo es impar";
            }
            else if (res >= 1 & res1 == 0)
            {
                tex = "los primer digito es impar y el segundo es par";
            }
            else
            {
                tex = "Ingreso una letra";
            }
            Console.WriteLine(tex);
            Console.ReadKey();
        }

    }
}
