namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main()
        {
            Box<string> items = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                items.Add(item);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(items.Compare(itemToCompare));
        }
    }
}
