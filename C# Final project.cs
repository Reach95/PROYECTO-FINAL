using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientado_a_objetos
{
    class Program
    {
        private static string usuario;
        private static string clave;
        private static bool usuariocheched, clavechecked = false;
        static List<WriteLine> write;


        private static List<string> usuarios = new List<string>()
        { "RCharles", "ECedno" };

        private static List<string> claves = new List<string>
        { "1111", "2222" };

        static void Main(string[] args)
        {
            WritrLine("grupo: NombreCreativoEnPascalCase.\n");
            WriteLine("integrantes:\n");
            WriteLine("15-SIST-1-057    Reando Charles.");
            WriteLine("15-SIST-1-027    Erick Cedeno.");
            Write("Pulse una tecla Para Continuar >");

            Readkey();
            clear();

            WriteLine("          INGRESA TU USUARIO Y CLAVE");
            Write("usuario >");
            usuario = ReadLine();

            Write("Clave>");
            clave = Readline();
            Clear();

            //Los siguentes foreach validan usuario y contrasena ingresados.
            foreach (var u in usuario)
            {
                if (u = usuario)
                {
                    usuariocheched = true;
                }
            }

            foreach (var c in claves)
            {
                if (c == clave)
                {
                    clavechecked = true;
                }
            }

            //codigo que se ejecuta una vez se haya cumplido con la validation.

            if (usuariocheched && clavechecked)
            {
                switch (usuario)
                {
                    case "RCharles":
                        WriteLine("Information de Reando chalres\n");
                        WriteLine("sector Laboral : Privado.\nEdad: 22.\nOcupation: Informatico.\nSalario: RD$30 mil.");

                        salir();   
                        break;
                    case "ECedeno":
                        Writeline("information De Erick Cedeno\n");
                        WriteLine("Sector laboral : Privado.\nEdad: 20.\nOcuapacion: Musico.\nSalario: RD$12 mil.");

                        salir();
                        break;
                }
            }
            else
            {
                Writeline("ERROR DE CREDENCIALES: (");
                salir;
            }

        }

        private static void salir()
        {
            Write("\noulse una tecla para salir>");
            ReadKey();
            Environment.Exit(0);

        }

    }
}




