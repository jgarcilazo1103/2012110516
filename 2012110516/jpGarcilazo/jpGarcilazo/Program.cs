using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpGarcilazo
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente = new cliente();

            cliente.nombre = "Jorge Luis";
            cliente.apellido = "Reyes Suarez";
            cliente.documentoIdentidad = "48252077";
            cliente.sexo = true;
            cliente.fechaRegistro = DateTime.Now;
            cliente.fechaActualización = DateTime.Now;


            Console.WriteLine(cliente.nombre);
            Console.WriteLine(cliente.apellido);
            Console.WriteLine(cliente.documentoIdentidad);
            Console.WriteLine(cliente.fechaRegistro);
            Console.WriteLine(cliente.fechaActualización);

            Console.ReadLine();


        }
        
        
    }
    
}
