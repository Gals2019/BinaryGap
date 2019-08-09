using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 20;
            String cadena = "";

            while (numero!=0)
            {

                int resultado = (int) numero/2;

                if (numero%2==0)
                {
                    cadena += "0";
                }
                else
                {
                    cadena += "1";
                }

                numero = resultado;
            }

            char [] ArrayCadena = cadena.ToCharArray();
            Array.Reverse(ArrayCadena);

            /*Ya tengo el numero decimal convertido en binario*/

            //Ahora cuento los GAPS

            List<String> gaps = new List<string>();

            String cadenaGap = "";

            for (int i = 0; i < ArrayCadena.Length; i++)
            {
                String valorActual = ArrayCadena[i].ToString();                

                if (valorActual=="0")
                {
                    cadenaGap += valorActual;

                    if (i+1<=ArrayCadena.Length-1)
                    {
                        if (ArrayCadena[i + 1].ToString() == "1")
                        {
                            gaps.Add(cadenaGap);
                            cadenaGap = "";
                        }
                    }
                    
                    
                }

            }

            int cant = 0;

            int cantMaxi = 0;

            foreach (String item in gaps)
            {
                cantMaxi = item.Length;
                if (cantMaxi>cant)
                {
                    cant=cantMaxi;
                }
            }

            //return cant;

            Console.WriteLine(cant);
            Console.ReadKey();

        }

        
    }
}
