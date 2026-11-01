namespace Ucu.Poo.Biblioteca
{
    public class Libro : IMaterial
    {
        public string Titulo { get; set; }
        public string CodigoIdentificador { get; set; }
        public void Aceptar(IVisitanteMaterial visitante)
        {
            visitante.Visitar(this);
        }
    }
    public class Revista : IMaterial
    {
        public string Titulo { get; set; }
        public string CodigoIdentificador { get; set; }
        public void Aceptar(IVisitanteMaterial visitante)
        {
            visitante.Visitar(this);
        }
    }
    public class DVD : IMaterial
    {
        public string Titulo { get; set; }
        public string CodigoIdentificador { get; set; }
        public void Aceptar(IVisitanteMaterial visitante)
        {
            visitante.Visitar(this);
        }
    }
}