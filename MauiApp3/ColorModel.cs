namespace MauiApp3;

public class ColorModel
{
    public string Name { get; set; }
    public int Count { get; set; }

    public ColorModel(string name)
    {
        Name = name;
        Count = Counter.ModelInstanceCounter;
    }
}
