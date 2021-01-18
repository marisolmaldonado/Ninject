namespace Ninject
{
    class Libreria : ILibrero
    {
        public string InstertarLibro()
        {
            string libro = "Se Ingreso un libro con inyecction de dependecia";
            Console.WriteLine(libro);
            return libro;

        }
    }
}
