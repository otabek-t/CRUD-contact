namespace g10;

internal class Program
{

    static void Main(string[] texts)
    {

        List<Animal> animals = new List<Animal>();

        Animal car1 = new Animal();
        car1.Type = "Tiger";
        car1.Color = "Red and black";
        car1.Speed = 60;
        car1.Weight = 150;
        car1.PlaceOfResidence = "Forest and Jungle";

        car1.DisplayInfo();
        
        
    }
}
