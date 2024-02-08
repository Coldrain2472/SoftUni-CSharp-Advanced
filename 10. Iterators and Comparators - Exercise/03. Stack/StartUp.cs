namespace Stack
{
    public class StartUp
    {
        public static void Main()
        {
            CustomStack<int> stack = new CustomStack<int>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandInfo = command
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandInfo[0];

                if (action == "Push")
                {
                    int[] itemsToPush = commandInfo
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in itemsToPush)
                    {
                        stack.Push(item);
                    }
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}