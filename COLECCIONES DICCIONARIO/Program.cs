namespace COLECCIONES_DICCIONARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> map = new Dictionary<String, int>();
            map.Add("juan", 23);
            map.Add("somail", 53);
            map.Add("royer", 23);
            map.Add("gadriel", 23);
         foreach(KeyValuePair<String,int>i in map)
            {
                Console.WriteLine(i.Key + i.Value);
            }
        }
    }
}