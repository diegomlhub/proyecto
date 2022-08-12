namespace Proyecto
{
    class prueba
    {
        static void Main(string[] args)
        {
            //ProductoHandler productoHandler = new ProductoHandler();

            //Producto producto =  new Producto();

            //producto = productoHandler.Get(1);

            //List<Producto> productos = productoHandler.Get();

            //productoHandler.Add(producto);

            ////productoHandler.Delete(16);
            
            //--------------
            
            UsuarioHandler usuarioHandler = new UsuarioHandler();
            
            Usuario usuario = new Usuario();

            //usuario = usuarioHandler.Get(1);

            //usuarioHandler.Add(usuario);


            //------Loguin-------

            Console.WriteLine("Ingrese la nombre de usuario:\n");

            string systemUser = Console.ReadLine();

            Console.WriteLine("\nIngrese la contraseña:\n");

            string systemPassword = Console.ReadLine();

            usuario = usuarioHandler.GetByCotraseña(systemUser, systemPassword);

            if (systemUser.Equals(usuario.NombreUsuario) & systemPassword.Equals(usuario.Contraseña))
            {
                Console.WriteLine("\nSe a logueado correctamente.\n");
            }
            else
            {
                Console.WriteLine("\nUsuario y contraseña inválidos.\n"); 
            }
        }
    }
}
