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

            productoHandler.Add(producto);

            //productoHandler.Delete(16);
            
            //--------------
            
            UsuarioHandler usuarioHandler = new UsuarioHandler();
            
            Usuario usuario = new Usuario();

            usuario = usuarioHandler.Get(1);

            usuarioHandler.Add(usuario);    

        }
    }
}
