namespace Proyecto
{
    class ProductoVendido : IId
    {
        private int _id;
        private int _idProducto;
        private long _stock;
        private int _idVenta;

        public int Id { get { return _id; } set { _id = value; } }
        public int IdProducto { get { return _idProducto; } set { _idProducto = value; } }
        public long Stock { get { return _stock; } set { _stock = value; } }
        public int IdVenta { get { return _idVenta; } set { _idVenta = value; } }

        public ProductoVendido()
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;
        }

        public ProductoVendido(int id, int idProducto, long stock, int idVenta)
        {
            _id = id;
            _idProducto = idProducto;
            _stock = stock;
            _idVenta = idVenta;
        }

        public string Mostrar()
        {
            return "ID: " + _id.ToString() + "\nId de Producto: " + _idProducto.ToString() + "\nStock: " + _stock.ToString() + "\nId de Venta: " + _idVenta.ToString();
        }
    }
}
