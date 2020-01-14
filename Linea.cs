using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweigth_def
{
    class Linea: I_Linea_Ligera
    {
         private String color;
       
         public Linea(String color)
         {
            this.color = color;
         }
       
       
          public String getColor()
        {
            return this.color;
        }
       
        
     public void dibujar(int col, int fila)
        {
           Console.WriteLine("Dibujando línea de color [" + this.color + "] en [" + col + ", " + fila + "]");
        }
    }
}
