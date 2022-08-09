namespace Proyecto
{
    class prueba
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Producto producto = new Producto();
            ProductoVendido productoVendido = new ProductoVendido(12,35,150,26);
            Venta venta = new Venta();

            Console.WriteLine("Usuario: ");
            Console.WriteLine(usuario.Mostrar());
            Console.WriteLine("\nProducto: ");
            Console.WriteLine(producto.Mostrar());
            Console.WriteLine("\nProducto Vendido: ");
            Console.WriteLine(productoVendido.Mostrar());

            Console.WriteLine("-------");

            //prueba para ver que los get y set funcionan correctamente
            productoVendido.Id = 25;

            Console.WriteLine("\nProducto Vendido: ");
            Console.WriteLine(productoVendido.Mostrar());



        }
    }
}
