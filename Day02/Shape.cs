namespace Day02;

public class Shape
{
    public static Shape Rock = new Shape()
    {
        Name = ShapeNames.Rock,
        Weakness = ShapeNames.Paper,
        BaseScore = 1,
    };
    public static Shape Paper = new Shape()
    {
        Name = ShapeNames.Paper,
        Weakness = ShapeNames.Scissors,
        BaseScore = 2,
    };
    public static Shape Scissors = new Shape()
    {
        Name = ShapeNames.Scissors,
        Weakness = ShapeNames.Rock,
        BaseScore = 3,
    };
    public ShapeNames Name { get; init; }
    public ShapeNames Weakness { get; init; }
    public int BaseScore { get; init; }
}

public enum ShapeNames
{
    Rock,
    Paper,
    Scissors
}