using System;

namespace CarLotSimulator;

public class Car
{
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string noise)
    {
        Console.WriteLine($"Engine noise: {noise}");
    }

    public void MakeHonkNoise(string noise)
    {
        Console.WriteLine($"Honk noise: {noise}");
    }
    
    
}