namespace ListaLigada.Logica
{
    public class SingleNode<T>
    {
        public T? Data { get; set; }
        public SingleNode<T>? Next { get; set; }

        // ctor para hacer el constructor +tab
        public SingleNode(T data)
        {
            Data = data;
            Next = null;
        }



    }
}
