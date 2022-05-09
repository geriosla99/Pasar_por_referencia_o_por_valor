using System;

namespace Pasar_por_referencia_o_por_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            //pasar por valor
            byte numAr;
            string saludoAR;
            int primoAR;
            
            Prueba(out numAr,out saludoAR, out primoAR);
            //despues que el metodo cambio su valor, volvemos a mostrar el argumento
            Console.WriteLine(numAr);
            Console.WriteLine(saludoAR);
            Console.WriteLine(primoAR);
        }

        static void Prueba(out byte numPa, out string saludosPa, out int primoPa)
        {
            //modificamos el valor del parametro

            numPa = 20;
            saludosPa = "Hola mundo";
            primoPa = 5;
        }

    }
}
