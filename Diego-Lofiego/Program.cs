namespace Proyecto
{
    class prueba
    {
        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();

            Producto producto =  new Producto();

            producto = productoHandler.TraerUnProducto(1);

            productoHandler.TraerProductos();
        }
    }
}
