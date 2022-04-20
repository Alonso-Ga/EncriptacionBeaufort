using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaufortPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] abecedario = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("BEAUFORT\n ¿QUE DESEA HACER?\n (1) ENCRIPTAR (2) DESENCRIPTAR");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {   
                //Mensaje en claro ingresa
                Console.WriteLine("Ingrese el Mensaje en claro: ");
                string mensajeclaro = Console.ReadLine();
                mensajeclaro = mensajeclaro.Replace(" ", string.Empty);
                mensajeclaro = mensajeclaro.ToLower();
                //llave
                Console.WriteLine("Ingrese llave: ");
                string llave = Console.ReadLine();
                llave = llave.Replace(" ", string.Empty);
                llave = llave.ToLower();

                int[] mclnumerico = new int[mensajeclaro.Length];
                int[] llavenumerico = new int[llave.Length];

                char[] arreglomensaje;
                arreglomensaje = mensajeclaro.ToCharArray(0, mensajeclaro.Length);

                char[] arreglollave;
                arreglollave = llave.ToCharArray(0, llave.Length);

                

                    for (int a = 0; a < arreglomensaje.Length; a++)
                    {
                        for (int i = 0; i < abecedario.Length; i++)
                        {
                            string varmens = arreglomensaje[a].ToString();
                            string varabc = abecedario[i].ToString();
                            if (varmens == varabc)
                            {
                                mclnumerico[a] = i;

                            }
                        }
                    }

                for (int a = 0; a < arreglollave.Length; a++)
                {
                    for (int i = 0; i < abecedario.Length; i++)
                    {
                        string varllav = arreglollave[a].ToString();
                        string varabc = abecedario[i].ToString();
                        if (varllav == varabc)
                        {
                            llavenumerico[a] = i;
                        }
                    }
                }
                double[] operacion = new double[llavenumerico.Length];

                for (int i = 0; i<llavenumerico.Length;i++)
                {
                    operacion[i] = mclnumerico[i] - llavenumerico[i];

                }
                double[] mod26 = new double[operacion.Length];
                double numero = 26;
                for (int i = 0; i < operacion.Length; i++)
                {
                    if(operacion[i] <= -1)
                    {
                        mod26[i] = operacion[i] + numero;
                    }
                    else
                    {
                        mod26[i] = operacion[i] % numero;
                    }
                }
                //asignar el abecedario
                string[] criptograma = new string[mod26.Length];
                for (int i = 0; i < mod26.Length; i++)
                {
                    for (int a = 0; a < abecedario.Length; a++)
                    {
                        double aux = a;
                        if(mod26[i] == a)
                        {
                            criptograma[i] = abecedario[a].ToString();
                        }

                    }
                }
                string CriptogramaF ="";

                foreach (string cf in criptograma)
                {
                    CriptogramaF = CriptogramaF + cf;
                }

                Console.WriteLine("CRIPTOGRAMA: " + CriptogramaF.ToUpper());
                Console.ReadKey();
            }
            if(opcion == "2")
            {
                //Mensaje en claro ingresa
                Console.WriteLine("Ingrese el Criptograma ");
                string mensajeclaro = Console.ReadLine();
                mensajeclaro = mensajeclaro.Replace(" ", string.Empty);
                mensajeclaro = mensajeclaro.ToLower();
                //llave
                Console.WriteLine("Ingrese llave: ");
                string llave = Console.ReadLine();
                llave = llave.Replace(" ", string.Empty);
                llave = llave.ToLower();

                int[] mclnumerico = new int[mensajeclaro.Length];
                int[] llavenumerico = new int[llave.Length];

                char[] arreglomensaje;
                arreglomensaje = mensajeclaro.ToCharArray(0, mensajeclaro.Length);

                char[] arreglollave;
                arreglollave = llave.ToCharArray(0, llave.Length);



                for (int a = 0; a < arreglomensaje.Length; a++)
                {
                    for (int i = 0; i < abecedario.Length; i++)
                    {
                        string varmens = arreglomensaje[a].ToString();
                        string varabc = abecedario[i].ToString();
                        if (varmens == varabc)
                        {
                            mclnumerico[a] = i;

                        }
                    }
                }

                for (int a = 0; a < arreglollave.Length; a++)
                {
                    for (int i = 0; i < abecedario.Length; i++)
                    {
                        string varllav = arreglollave[a].ToString();
                        string varabc = abecedario[i].ToString();
                        if (varllav == varabc)
                        {
                            llavenumerico[a] = i;
                        }
                    }
                }
                double[] operacion = new double[llavenumerico.Length];

                for (int i = 0; i < llavenumerico.Length; i++)
                {
                    operacion[i] = mclnumerico[i] + llavenumerico[i];

                }
                double[] mod26 = new double[operacion.Length];
                double numero = 26;
                for (int i = 0; i < operacion.Length; i++)
                {
                    if (operacion[i] <= -1)
                    {
                        mod26[i] = operacion[i] + numero;
                    }
                    else
                    {
                        mod26[i] = operacion[i] % numero;
                    }
                }
                //asignar el abecedario
                string[] criptograma = new string[mod26.Length];
                for (int i = 0; i < mod26.Length; i++)
                {
                    for (int a = 0; a < abecedario.Length; a++)
                    {
                        double aux = a;
                        if (mod26[i] == a)
                        {
                            criptograma[i] = abecedario[a].ToString();
                        }

                    }
                }
                string CriptogramaF = "";

                foreach (string cf in criptograma)
                {
                    CriptogramaF = CriptogramaF + cf;
                }

                Console.WriteLine("Mensaje en claro: " + CriptogramaF.ToUpper());
                Console.ReadKey();
            }
        }
    }
}
