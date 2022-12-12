string[] input = File.ReadAllLines("input.txt");
List<int> caloriesSums = new List<int>();
int currentCalories = 0;
for (int i = 0; i < input.Length; i++)
{
    string line = input[i];
    if(string.IsNullOrEmpty(line))
    {
        caloriesSums.Add(currentCalories);
        currentCalories = 0;
    }
    else
    {
        if (int.TryParse(line, out int calories))
            currentCalories += calories;
    }
}
Console.WriteLine($"Top calories: {caloriesSums.OrderBy(cal => cal).Last()}");
Console.WriteLine($"Top 3 calories: {caloriesSums.OrderBy(cal => cal).TakeLast(3).Sum()}");