using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Plus;

public class Academy
{
    public string Students { get; set; }
    public int Employers { get; set; }
    public string Teachers { get; set; }
    public string Subjects { get; set; }
    public int Tables { get; set; }
    public  int Rooms { get; set; }

    public void DisplayInfo()
    {
        string firstinfo = $"Students {Students}";
        string secondinfo = $"Students {Employers}";
        string thirdinfo = $"Students {Teachers}";
        string fourthinfo = $"Students {Subjects}";
        string fifthinfo = $"Students {Tables}";
        string sixthinfo = $"Students {Rooms}";
        Console.WriteLine(firstinfo);
        Console.WriteLine(secondinfo);
        Console.WriteLine(thirdinfo);
        Console.WriteLine(fourthinfo);
        Console.WriteLine(firstinfo);
        Console.WriteLine(sixthinfo);
        
    }

}
