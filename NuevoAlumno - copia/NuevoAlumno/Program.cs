using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NuevoAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que id tiene este alumno?");
            string idAl = Console.ReadLine();
            int numId = int.Parse(idAl);

            Console.WriteLine("Por favor su: ");

            Console.Write("Nombre: ");
            string nombreAl = Console.ReadLine();

            Console.Write("Apellidos: ");
            string apellAl = Console.ReadLine();

            Console.Write("DNI: ");
            string dniAl = Console.ReadLine();
            int numDni = int.Parse(dniAl);
        }
        // WriteAllLines creates a file, writes a collection of strings to the file,
        // and then closes the file.
        string[] text = $"{ numId }, {nombreAl }, {apellAl}, {numDni}";
        File.WriteAllText(@"C:\Users\Daniel Contreras\source\repos\NuevoAlumno\NuevoAlumno.fichero.txt",
            text);
    }
}


