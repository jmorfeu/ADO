using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repaso002
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudiantes persona = new Estudiantes();

            Console.WriteLine("Inserte el Nombre: ");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Inserte el Apellido: ");
            persona.Apellido = Console.ReadLine();

            Conexion conexion = new Conexion();
            try
            {
                conexion.InsertEstudiantes(persona);
                Console.WriteLine("Registro Insertado Correctamente");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            

        }


    
    }
}
