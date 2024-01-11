int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int capacity = int.Parse(Console.ReadLine());

Stack<int> clothesStack = new Stack<int>(clothes);

int sumClothesValue = 0;
int rack = 1;
while (clothesStack.Count > 0)
{
    if (sumClothesValue + clothesStack.Peek() < capacity)
    {
        sumClothesValue += clothesStack.Pop();
    }
    else if (capacity == sumClothesValue + clothesStack.Peek())
    {
        sumClothesValue += clothesStack.Pop();
        if (clothesStack.Count > 0)
        {
            sumClothesValue = 0;
            rack++;
        }
    }
    else if (sumClothesValue + clothesStack.Peek() > capacity)
    {
        sumClothesValue = 0;
        rack++;
    }
}
    Console.WriteLine(rack);
