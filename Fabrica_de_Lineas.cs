using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweigth_def
{
    class Fabrica_de_Lineas
    {
        private List<I_Linea_Ligera> lineas;
        // --------------------
        public Fabrica_de_Lineas()
        {
            this.lineas = new List<I_Linea_Ligera>();
        }
        // --------------------
        public I_Linea_Ligera getLine(String color)
        {
            // Comprobar si hemos creado una línea con el color solicitado, y devolverla en tal caso
            foreach (I_Linea_Ligera lineasi in this.lineas)
            {
                if (lineasi.getColor().Equals(color))
                {
                    Console.WriteLine("Línea de color [" + color + "] encontrada, la devolvemos");
                    return lineasi;
                }
            }
            // Si no ha sido creada la creamos ahora, la agregamos a la lista y la devolvemos
            Console.WriteLine("Creando una línea de color [" + color + "]");
            I_Linea_Ligera linea = new Linea(color);
            this.lineas.Add(linea);
            return linea;
        }
    }
}
