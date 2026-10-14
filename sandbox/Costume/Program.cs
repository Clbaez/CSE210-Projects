namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Costume World!");

        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._footWear = "dress shoes";
        detective._accessories = "magnifying glass";
        myCostumes.Add(detective);

        Costume nurse = new Costume();
        nurse._headwear = "nurse cap";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._footWear = "orthopedic shoes";
        nurse._accessories = "stethoscope";
        myCostumes.Add(nurse);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }
    }
}
