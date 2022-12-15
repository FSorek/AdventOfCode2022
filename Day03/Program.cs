string[] input = File.ReadAllLines("input.txt");
int totalScore = 0;
for (int i = 0; i < input.Length; i+=3)
{
    string firstLine = input[i];
    string secondLine = input[i + 1];
    string thirdLine = input[i + 2];

    var intersect = firstLine.Intersect(secondLine).Intersect(thirdLine).ToArray();

    foreach (char letter in intersect)
    {
        int letterScore = letter - 96;
        if (letterScore < 0) letterScore += 58;
        totalScore += letterScore;
    }
}
Console.WriteLine(totalScore);

(IEnumerable<char>, IEnumerable<char>) GetItemsInCompartments(string line)
{
    int itemsPerCompartment = (int)Math.Round(line.Length / 2f);
    var firstCompartment = line.Take(itemsPerCompartment);
    var secondCompartment = line.TakeLast(itemsPerCompartment);
    return new(firstCompartment, secondCompartment);
}