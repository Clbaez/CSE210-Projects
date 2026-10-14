namespace Costume;

class Costume
{
    // Attributes
    public string _headwear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footWear;
    public string _accessories;
    // Behavior
    public void Output()
    {
        Console.WriteLine("Costume pieces:");
        Console.WriteLine($"head: {_headwear}");
        Console.WriteLine($"torso: {_upperGarment}");
        Console.WriteLine($"legs: {_lowerGarment}");
        Console.WriteLine($"feet {_footWear}");
        Console.WriteLine($"other: {_accessories}");
    }
}