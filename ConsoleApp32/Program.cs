namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a ededini daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b ededini daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());           
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }          
            int uzunluq = b - a + 1;
            int[] massiv = new int[uzunluq];          
            for (int i = 0; i < uzunluq; i++)
            {
                massiv[i] = a + i;
            }           
            for (int i = 0; i < uzunluq; i++)
            {
                int eded = massiv[i];
                int kvadrat = eded * eded;
                int kub = eded * eded * eded;
                Console.WriteLine($"{eded}-in kvadrati: {kvadrat}, kubu: {kub}");
            }


        }
    }
}
