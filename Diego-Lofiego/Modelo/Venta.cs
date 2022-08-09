namespace Proyecto
{
    class Venta : IId
    {
        private int _id;
        private string _comentarios;
        
        public int Id { get { return _id; } set { _id = value; } }
        public string Comentarios { get { return _comentarios; } set { _comentarios = value; } }

        public Venta()
        {
            _id = 0;
            _comentarios = String.Empty;
        }

        public Venta(int id, string comentarios)
        {
            _id = id;
            _comentarios = comentarios;
        }
    }

}
