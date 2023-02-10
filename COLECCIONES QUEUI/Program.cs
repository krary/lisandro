namespace COLECCIONES_QUEUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Queue<int> numeros = new Queue<int>();
             foreach(int i in new int[] { 2323, 23, 45, 6 })
            {
                numeros.Enqueue(i);
            }
             foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
            numeros.Dequeue();
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Stack<int> stack = new Stack<int>();
            foreach(int i in new int[] { 1, 2, 3, 4, 5, 6 })
            {
                stack.Push(i);
            }
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}