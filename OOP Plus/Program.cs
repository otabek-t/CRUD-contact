using Microsoft.VisualBasic;

namespace OOP_Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }
        public static void RunFrontEnd()
        {
            var AcademyInformation = new List<Academy>();
            AcademyInformation.Add("Otabek Tursunov");
            var Academy = new Academy();

            while (true)
            {
                Console.WriteLine("1. Add the information of Academy: ");
                Console.WriteLine("2. Delete the information: ");
                Console.WriteLine("3. Update the information: ");
                Console.WriteLine("4. Show all information: ");
                Console.WriteLine();
                Console.WriteLine("Choose the option: ");
                var option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Studen's name: ");
                    Academy.Students = Console.ReadLine();

                    Console.WriteLine("The count of Employers: ");
                    Academy.Employers = int.Parse(Console.ReadLine());

                    Console.WriteLine("Teacher's name: ");
                    Academy.Teachers = Console.ReadLine();

                    Console.WriteLine("Subjects: ");
                    Academy.Subjects = Console.ReadLine();

                    Console.WriteLine("The count of tables: ");
                    Academy.Tables = int.Parse(Console.ReadLine());

                    Console.WriteLine("The counnt of rooms: ");
                    Academy.Rooms = int.Parse(Console.ReadLine());

                    AcademyInformation.Add(Academy);
                    Console.WriteLine("Added success.");
                 

                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter the information to delete: ");
                    var deleteText = Console.ReadLine();
                    
                }
                else if (option == 3)
                {

                }
                else if (option == 4)
                {
                    string firstinfo = $"Students: {Academy.Students}";
                    string secondinfo = $"The count of employer: {Academy.Employers}";
                    string thirdinfo = $"Teacher's name: {Academy.Teachers}";
                    string fourthinfo = $"Subject's name: {Academy.Subjects}";
                    string fifthinfo = $"The count of tables: {Academy.Tables}";
                    string sixthinfo = $"The count of rooms: {Academy.Rooms}";
                    Console.WriteLine(firstinfo);
                    Console.WriteLine(secondinfo);
                    Console.WriteLine(thirdinfo);
                    Console.WriteLine(fourthinfo);
                    Console.WriteLine(firstinfo);
                    Console.WriteLine(sixthinfo);
                }
                else
                {
                    Console.WriteLine("Enter again!");
                }
            }
        }
        public static void DeleteFunction(string function)
        {
            var checkDelete = Academy
        }
    }
}
