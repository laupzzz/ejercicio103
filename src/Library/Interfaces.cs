namespace Ucu.Poo.Biblioteca
{
    public interface IMaterial
    {
        void Aceptar(IVisitanteMaterial visitante);
    }
    public interface IVisitanteMaterial
    {
        void Visitar(Libro libro);
        void Visitar(Revista revista);
        void Visitar(DVD dvd);
    }
}