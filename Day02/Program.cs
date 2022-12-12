using Day02;

Dictionary<string, Shape> moves = new Dictionary<string, Shape>()
{
    {"A", Shape.Rock},
    {"B", Shape.Paper},
    {"C", Shape.Scissors},
    {"X", Shape.Rock},
    {"Y", Shape.Paper},
    {"Z", Shape.Scissors},
};
string[] input = File.ReadAllLines("input.txt");
int myScore = 0;
for (int i = 0; i < input.Length; i++)
{
    string line = input[i];
    string[] currentPlay = line.Split(" ");
    myScore += GetScore(currentPlay[0], currentPlay[1]);
}
Console.WriteLine(myScore);
int GetScore(string enemyMove, string myMove)
{
    var myShape = moves[myMove];
    var enemyShape = moves[enemyMove];
    
    if (myShape == enemyShape)
        return 3 + myShape.BaseScore;
    else
    {
        if (myShape.Weakness == enemyShape.Name)
            return 0 + myShape.BaseScore;
        else return 6 + myShape.BaseScore;
    }
}