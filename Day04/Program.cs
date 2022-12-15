string[] input = File.ReadAllLines("input.txt");
int containSum = 0;
for (int i = 0; i < input.Length; i++)
{
    string line = input[i];
    string[] pairedSections = line.Split(',');
    int[] firstSectionRange = GetSectionRange(pairedSections[0]);
    int[] secondSectionRange = GetSectionRange(pairedSections[1]);
    if (firstSectionRange[0] <= secondSectionRange[0] && firstSectionRange[1] >= secondSectionRange[1]
        || secondSectionRange[0] <= firstSectionRange[0] && secondSectionRange[1] >= firstSectionRange[1])
        containSum++;
}
Console.WriteLine(containSum);
int[] GetSectionRange(string pairedSection)
{
    string[] numbers = pairedSection.Split('-');
    return numbers.Select(num => int.Parse(num)).ToArray();
}