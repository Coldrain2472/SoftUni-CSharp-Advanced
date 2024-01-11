Queue<string> cars = new Queue<string>();
int n = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
int passedCars = 0;
while (command != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count > 0)
            {
                string car = cars.Dequeue();
                Console.WriteLine($"{car} passed!");
                passedCars++;
            }
        }
    }
    else
    {
        cars.Enqueue(command);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{passedCars} cars passed the crossroads.");
