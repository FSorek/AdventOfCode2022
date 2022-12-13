namespace Day02;

public interface IShape
{
    public ShapeNames Name { get; }
    public IShape Weakness { get; }
    public int BaseScore { get; }
}
public class Rock : IShape
{
    public ShapeNames Name { get; } = ShapeNames.Rock;
    public IShape Weakness => new Paper();
    public int BaseScore { get; } = 1;
}
public class Paper : IShape
{
    public ShapeNames Name { get; } = ShapeNames.Paper;
    public IShape Weakness => new Scissors();
    public int BaseScore { get; } = 2;
}
public class Scissors : IShape
{
    public ShapeNames Name { get; } = ShapeNames.Scissors;
    public IShape Weakness => new Rock();
    public int BaseScore { get; } = 3;
}
public enum ShapeNames
{
    Rock,
    Paper,
    Scissors
}

public class Shape
{
    public static readonly Shape Rock = new Shape()
    {
        Name = ShapeNames.Rock,
        Score = 1
    };
    public static readonly Shape Paper = new Shape()
    {
        Name = ShapeNames.Paper,
        Score = 2
    };
    public static readonly Shape Scissors = new Shape()
    {
        Name = ShapeNames.Scissors,
        Score = 3
    };

    public ShapeNames Name { get; init; }
    public int Score { get; init; }
}