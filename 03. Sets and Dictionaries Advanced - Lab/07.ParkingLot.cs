string command = string.Empty;
HashSet<string> cars = new HashSet<string>();
while ((command = Console.ReadLine()) != "END")
{
    string[] input = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
	string direction = input[0];
	string car = input[1];
	if (direction == "IN")
	{
		cars.Add(car);
	}
	else // OUT
	{
		cars.Remove(car);

	}
}
if (cars.Count > 0)
{
	foreach (var car in cars)
	{
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
