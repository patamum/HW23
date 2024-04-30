namespace Task23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32 (Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i < n; i++) 
            { 
                f *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(f);
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}