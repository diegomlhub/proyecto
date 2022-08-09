namespace Proyecto
{
    class Producto : IId
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public int Id { get { return _id; } set { _id = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public double Costo { get { return _costo; } set { _costo = value; } }
        public double PrecioVenta { get { return _precioVenta; } set { _precioVenta = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }

        public Producto()
        {
            _id = 0;
            _descripcion = String.Empty;
            _costo = 0.0;
            _precioVenta = 0.0;
            _stock = 0;
            _idUsuario = 0;
        }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _idUsuario = idUsuario;
        }

        public string Mostrar()
        {
            return "ID: " + _id.ToString() + "\nDescripcion: " + _descripcion + "\nCosto: " + _costo.ToString() + "\nPrecio de Venta: " + _precioVenta.ToString() 
                + "\nStock: " + _stock.ToString() + "\nID de Usuario: " + _idUsuario.ToString();
        }

    }

}
