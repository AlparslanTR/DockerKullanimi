internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        while (i<10000)
        {
            Console.WriteLine("Hello, World! "+i);
            i++;
            Thread.Sleep(100)
        }
        
    }
}