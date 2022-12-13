string[] input = File.ReadAllLines("input.txt");
int totalScore = 0;
for (int i = 0; i < input.Length; i++)
{
    string line = input[i];
    int itemsPerCompartment = (int)Math.Round(line.Length / 2f);
    var firstCompartment = line.Take(itemsPerCompartment);
    var secondCompartment = line.TakeLast(itemsPerCompartment);

    char[] intersection = firstCompartment.Intersect(secondCompartment).ToArray();
    foreach (char letter in intersection)
    {
        int letterScore = letter - 96;
        if (letterScore < 0) letterScore += 58;
        totalScore += letterScore;
    }
}
Console.WriteLine(totalScore);