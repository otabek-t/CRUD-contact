namespace g10;

public class Animal
{
   
    public string Type { get; set; }

    public string Color { get; set; } 

    public double Speed { get; set; }

    public string Feet { get; set; }

    public int Weight { get; set; }

    public string PlaceOfResidence { get; set; }


    public void DisplayInfo()
    {
        string res = $"Name : {Type},  Color : {Color}, Speed : {Speed}, Weight : {Weight}, Place of residence : {PlaceOfResidence}";
        Console.WriteLine(res);
    }
}
