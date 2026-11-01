using System.Collections.Generic;

namespace Ucu.Poo.Biblioteca
{
    public class RegistroBiblioteca
    {
        private static RegistroBiblioteca instancia;
        private List<IMaterial> materiales = new List<IMaterial>();
        private RegistroBiblioteca() { }
        public static RegistroBiblioteca ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new RegistroBiblioteca();
            }
            return instancia;
        }
        public void AgregarMaterial(IMaterial material)
        {
            materiales.Add(material);
        }
        public List<IMaterial> ObtenerMateriales()
        {
            return materiales;
        }
    }
}