namespace CourseDesignPattern.Observer
{
    public interface IObserver
    {
        //// Técnica com Callbacks
        //public delegate void Callback(T source, string name);
        //public Callback callback;

        //// Técnica com programação funcional
        //public delegate void Fuction();
        //public Fuction fuction;

        void Execute();
    }
}
