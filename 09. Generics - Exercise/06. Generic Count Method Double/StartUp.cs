namespace GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main()
        {
            Box<double> items = new Box<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double item = double.Parse(Console.ReadLine());
                items.Add(item);
            }

            double itemToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(items.Compare(itemToCompare));
        }
    }
}