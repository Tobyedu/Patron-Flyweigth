using System;

namespace Flyweigth_def
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Fabrica_de_Lineas fabrica = new Fabrica_de_Lineas();
            I_Linea_Ligera linea1 = fabrica.getLine("AZUL");
            I_Linea_Ligera linea2 = fabrica.getLine("ROJO");
            I_Linea_Ligera linea3 = fabrica.getLine("AMARILLO");
            I_Linea_Ligera linea4 = fabrica.getLine("AZUL");
            Console.WriteLine ("-------------------");
       

            linea1.dibujar(100, 400);
            linea2.dibujar(200, 500);
            linea3.dibujar(300, 600);
            linea4.dibujar(400, 700);
        }
    }
}
