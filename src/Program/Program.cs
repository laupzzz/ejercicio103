using System;
using Ucu.Poo.Biblioteca;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroBiblioteca registro = RegistroBiblioteca.ObtenerInstancia();
            registro.AgregarMaterial(new Libro{Titulo="C# Avanzado", CodigoIdentificador = "L001" });
            registro.AgregarMaterial(new Libro{Titulo="Patrones de Diseño", CodigoIdentificador = "L002" });
            registro.AgregarMaterial(new Revista{Titulo="Techcon", CodigoIdentificador = "R001" });
            registro.AgregarMaterial(new DVD { Titulo ="Prog desde 0", CodigoIdentificador = "D001" });
            InspectorMateriales inspector = new InspectorMateriales();
            Console.WriteLine("=== INSPECCIÓN DE MATERIALES ===");
            foreach (IMaterial material in registro.ObtenerMateriales())
            {
                material.Aceptar(inspector);
            }
            RegistroBiblioteca registro1 = RegistroBiblioteca.ObtenerInstancia();
            RegistroBiblioteca registro2 = RegistroBiblioteca.ObtenerInstancia();
            Console.WriteLine();
            Console.WriteLine($"¿Es el mismo registro?: {registro1 == registro2}");
        }
    }
}