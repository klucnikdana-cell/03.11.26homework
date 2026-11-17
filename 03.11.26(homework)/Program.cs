namespace _03._11._26_homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------TASK1-----------\n");
            Swap swap = new Swap();
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before: a = {a}, b = {b}");

            swap.SwapChange(ref a, ref b);

            Console.WriteLine($"After: a = {a}, b = {b}");


            Console.WriteLine("\n----------TASK2-----------\n");
        }
    }
}
