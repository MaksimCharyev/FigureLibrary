
namespace SquareLibrary
{
    interface IWrite
    {
        void Write();
    }
    
    public class ConsoleWriter<T> : IWrite
    {
        public T Figure { get; set; }
        public ConsoleWriter(T figure) 
        {
            Figure = figure;
        }
        public void Write()
        {
            Console.WriteLine(Figure.ToString());
        }
    }
}