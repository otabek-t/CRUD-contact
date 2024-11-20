namespace OOP_Restoran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restourant> list = new List<Restourant>();

            Restourant FirstMenu = new Restourant();

            FirstMenu.FoodName = "Sho'rva";
            FirstMenu.HowMuch = 350;
            FirstMenu.Price = 25000;
            FirstMenu.TakeAWay = "yes or no";
            FirstMenu.InTheHall = "yes or no";


            Restourant SecondMenu = new Restourant();

            SecondMenu.FoodName = "Osh";
            SecondMenu.HowMuch = 500;
            SecondMenu.Price = 35000;
            SecondMenu.TakeAWay = "yes or no";
            SecondMenu.InTheHall = "yes or no";


            FirstMenu.DisplayInfo();
            SecondMenu.DisplayInfo();


        }
    }
}
