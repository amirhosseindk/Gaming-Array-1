int g = Convert.ToInt32(Console.ReadLine().Trim());

for (int gItr = 0; gItr < g; gItr++)
{
    int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    string result = gamingArray(arr);

    Console.WriteLine(result);
}
static string gamingArray(List<int> arr)
{
    var currentPlayer = 1;
    while (true)
    {
        var arrayLength = arr.Count;
        if (arrayLength == 0)
            break;
        var maxNum = arr.Max();
        var maxIndex = arr.FindIndex(x => x == maxNum);
        for (int i = maxIndex; i < arr.Count; i++)
        {
            arr.Remove(i);
        }
        currentPlayer = currentPlayer == 1 ? 2 : 1;
    }
    if (currentPlayer == 1)
        return "ANDY";

    return "BOB";
}

//int maxElement = int.MinValue;
//int moves = 0;

//foreach (var element in arr)
//{
//    if (element > maxElement)
//    {
//        maxElement = element;
//        moves++;
//    }
//}

//return moves % 2 == 0 ? "ANDY" : "BOB";