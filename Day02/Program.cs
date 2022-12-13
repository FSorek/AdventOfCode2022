using Day02;

Dictionary<string, Shape> moves = new Dictionary<string, Shape>()
{
    {"A", Shape.Rock},
    {"B", Shape.Paper},
    {"C", Shape.Scissors},
};
Dictionary<Shape, Shape> losingShapes = new Dictionary<Shape, Shape>()
{
    {Shape.Rock, Shape.Paper},
    {Shape.Paper, Shape.Scissors},
    {Shape.Scissors, Shape.Rock},
};
string[] input = File.ReadAllLines("input.txt");
int myScore = 0;
for (int i = 0; i < input.Length; i++)
{
    string line = input[i];
    string[] currentPlay = line.Split(" ");
    Shape myShape = new Shape();
    var enemyShape = moves[currentPlay[0]];
    var winningShape = losingShapes[enemyShape];
    switch (currentPlay[1])
    {
        case "X":
            myShape = losingShapes[winningShape];
            break;
        case "Y":
            myShape = enemyShape;
            break;
        case "Z":
            myShape = winningShape;
            break;
    }
    myScore += GetScore(enemyShape, myShape);
}
Console.WriteLine(myScore);
int GetScore(Shape enemyShape, Shape myShape)
{
    if (myShape.Name == enemyShape.Name)
        return 3 + myShape.Score;
    else
    {
        if (losingShapes[myShape] == enemyShape)
            return 0 + myShape.Score;
        else return 6 + myShape.Score;
    }
}