namespace g10;

internal class Program
{
    public static List<string> CarNumbers = new List<string>();


    public static void CarNumberDataSeed()
    {
        CarNumbers.Add("01A777AA");
        CarNumbers.Add("01U777UZ");
        CarNumbers.Add("60Z123CC");
        CarNumbers.Add("75D741DB");
        CarNumbers.Add("01001PPP");
    }

    static void Main(string[] texts)
    {
        CarNumberDataSeed();
        StartFrontEnd();
    }

    public static void StartFrontEnd()
    {
        while (true)
        {
            Console.WriteLine("1. Add carNumber");
            Console.WriteLine("2. Delete carNumber");
            Console.WriteLine("3. Update carNumber");
            Console.WriteLine("4. Read carNumber");
            Console.Write("Choose : ");
            var option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter new carNumber : ");
                var passportcarNumber = Console.ReadLine();
                var index = AddCarNumber(passportcarNumber);
                if (index == -1)
                {
                    Console.WriteLine("Not added, error occured");
                }
                else
                {
                    Console.WriteLine($"Added, successed index : {index}");
                }
            }
            else if (option == 2)
            {
                Console.Write("Enter deleted carNumber : ");
                var passportcarNumber = Console.ReadLine();
                var boolResult = DeleteCarNumber(passportcarNumber);
                if (boolResult is true)
                {
                    Console.WriteLine("Deleted, successed");
                }
                else
                {
                    Console.WriteLine("Not deleted, error occured");
                }
            }
            else if (option == 3)
            {
                Console.Write("Enter old carNumber : ");
                var oldPassportcarNumber = Console.ReadLine();
                Console.Write("Enter updated carNumber : ");
                var newPassportcarNumber = Console.ReadLine();
                var boolResult = UpdateCarNumber(oldPassportcarNumber, newPassportcarNumber);
                if (boolResult is true)
                {
                    Console.WriteLine("Updated, successed");
                }
                else
                {
                    Console.WriteLine("Not update, error occured");
                }
            }
            else if (option == 4)
            {
                var carNumbers = GetCarNumbers();
                foreach (var carNumber in carNumbers)
                {
                    Console.WriteLine(carNumber);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    public static int AddCarNumber(string carNumber)
    {
        var contains = CarNumbers.Contains(carNumber);
        if (contains is true)
        {
            return -1;
        }
        if (CheckFormatCitizensCarNumber(carNumber) is false
            && CheckFormatGovermentalCarNumber(carNumber) is false)
        {
            return -1;
        }

        carNumber = carNumber.ToUpper();
        CarNumbers.Add(carNumber);
        var index = CarNumbers.IndexOf(carNumber);

        return index;
    }

    public static bool DeleteCarNumber(string carNumber)
    {
        var contains = CarNumbers.Contains(carNumber);
        if (contains is false)
        {
            return false;
        }

        CarNumbers.Remove(carNumber);
        return true;
    }

    public static List<string> GetCarNumbers()
    {
        return CarNumbers;
    }

    public static bool UpdateCarNumber(string oldCarNumber, string newCarNumber)
    {
        newCarNumber = newCarNumber.ToUpper();
        var oldCarNumberContains = CarNumbers.Contains(oldCarNumber);
        var newCarNumberContains = CarNumbers.Contains(newCarNumber);
        if (oldCarNumberContains is false)
        {
            return false;
        }

        if (newCarNumberContains is true)
        {
            return false;
        }

        if (CheckFormatCitizensCarNumber(newCarNumber) is false
            && CheckFormatGovermentalCarNumber(newCarNumber) is false)
        {
            return false;
        }

        var index = CarNumbers.IndexOf(oldCarNumber);
        CarNumbers[index] = newCarNumber;

        return true;
    }

    public static bool CheckFormatGovermentalCarNumber(string carNumber)
    {
        if (carNumber.Length != 8)
        {
            return false;
        }

        for (var i = 0; i < 5; i++)
        {
            if (Char.IsDigit(carNumber[i]) is false)
            {
                return false;
            }
        }

        for (var i = 5; i < carNumber.Length; i++)
        {
            if (Char.IsLetter(carNumber[i]) is false)
            {
                return false;
            }
        }

        return true;
    }

    public static bool CheckFormatCitizensCarNumber(string carNumber)
    {
        var isLengthCorrect = false;
        var firstTwoAndCenterThreeDigits = false;
        var thirdCharAndLastTwoLetter = false;

        if (carNumber.Length == 8)
        {
            isLengthCorrect = true;
        }

        if (Char.IsDigit(carNumber[0]) && Char.IsDigit(carNumber[1])
            && Char.IsDigit(carNumber[3]) && Char.IsDigit(carNumber[4])
            && Char.IsDigit(carNumber[5]))
        {
            firstTwoAndCenterThreeDigits = true;
        }

        if (Char.IsLetter(carNumber[2]) && Char.IsLetter(carNumber[6])
            && Char.IsLetter(carNumber[7]))
        {
            thirdCharAndLastTwoLetter = true;
        }

        return isLengthCorrect && firstTwoAndCenterThreeDigits && thirdCharAndLastTwoLetter;
    }
}
