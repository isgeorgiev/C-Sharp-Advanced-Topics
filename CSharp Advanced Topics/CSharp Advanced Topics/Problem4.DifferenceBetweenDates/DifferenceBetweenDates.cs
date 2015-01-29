using System;
class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter start date in format dd.MM.yyyy: ");
        DateTime startDate;
        bool startDateParse = DateTime.TryParse(Console.ReadLine(), out startDate);
        Console.Write("Enter end date in format dd.MM.yyyy: ");
        DateTime endDate;
        bool endDateParse = DateTime.TryParse(Console.ReadLine(), out endDate);
        if (startDateParse && endDateParse)
        {
            Console.WriteLine(daysDifference(startDate, endDate));
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
    static double daysDifference(DateTime startDate, DateTime endDate)
    {
        double days = (endDate - startDate).TotalDays;
        return days;
    }
}