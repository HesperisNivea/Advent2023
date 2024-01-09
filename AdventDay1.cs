namespace Advent2023;

public static class AdventDay1
{
    
    // check all lines 
    // save all numbers in list 
    //add to numbers (first and last)
    // add them all 
    public static void Day1()
    {
        long total = 0;

        while (Console.ReadLine() is { } line)
        {
            if (line != "")
            {
                var firstDigit = line.First(l => char.IsDigit(l)) - '0';
            
                var lastDigit = line.Last(l => char.IsDigit(l)) - '0';

            
                var fullNumber = firstDigit * 10 + lastDigit;
            
                total += fullNumber;

            }
            else
            {
                break;
            }
            
        }

        Console.WriteLine(total);
    }

    public static void Day2()
    {

    }
    
}                    