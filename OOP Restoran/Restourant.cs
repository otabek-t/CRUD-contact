using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Restoran;

internal class Restourant
{
    // proporty
    public string FoodName { get; set; }
    public int HowMuch { get; set; }
    public int Price { get; set; }
    public string TakeAWay { get; set; }
    public string InTheHall { get; set; }
    public void DisplayInfo()
    {
    string result = $"Food name: {FoodName}How much: {HowMuch}, Price: {Price}, Take a way: {TakeAWay}, In the Hall: {InTheHall}";
    Console.WriteLine(result);
    }
    
}

