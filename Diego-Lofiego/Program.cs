namespace Proyecto
{
    class prueba
    {
        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();

            Producto producto =  new Producto();

            producto = productoHandler.Get(1);

            List<Producto> productos = productoHandler.Get();
        }
    }
}
