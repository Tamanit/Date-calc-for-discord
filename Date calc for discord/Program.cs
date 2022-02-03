using System.Text.RegularExpressions;

Calculations newCalc = new Calculations();

class Calculations
{
    private enum DateInSeconds
    {
        Day = 86400,
        Year365 = 31536000,
        Year366 = 31622400
    }

    private enum MonthsInDays
    {
        January = 31,

        February365 = 28,
        February366 = 29,

        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31,
        September = 30,
        October = 31,
        November = 30,
        December = 31
    }

    private char style;

    private string ReadDate;

    private String[] TypeOfDate = {"t", "T", "d", "D", "f"};

    public Calculations()
    {
        var CurrientDate = DateTime.Now;

        do
        {
            Console.WriteLine("Введите дату, время\nПример: {0}", CurrientDate.ToString("g"));
            ReadDate = Console.ReadLine(); 
        } while (Validation(ReadDate) == false);

        Console.WriteLine("\nВведите фромат\nВозможные варианты:");

        foreach (var i in TypeOfDate)
            Console.WriteLine("    {0} --> {1}", i, CurrientDate.ToString(i));
            Console.WriteLine("    F --> {0}", CurrientDate.ToString("dddd d MMMM yyyyг. HH:mm"));
            Console.WriteLine("    R --> Сегодня");
        style = Console.ReadLine()[0];
    }

    private bool Validation(string DateTime)
    {
        // проверка правильности формата написания
        bool check = !string.IsNullOrEmpty(DateTime) && Regex.IsMatch(DateTime, @"^[0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[0-9]{4} [0-2]{1}[0-9]{1}:[0-5]{1}[0-9]{1}$");
        if (check == false) { Console.WriteLine("Ошибка, проверьре правильность введенной строки\n"); return check; };

        //
       /* Regex RegexForYear = new Regex(@"[1-9]{1}[0-9]{3}");
        bool check = !string.IsNullOrEmpty(DateTime) && Regex.IsMatch(DateTime, @"^[0|1]{1}[][.]{1}[0-9]{2}[.]{1}[0-9]{4} [0-9]{2}[:]{1}[0-9]{2}$");
        if (check == false) Console.WriteLine("Ошибка, проверьре правильность введенной строки\n");*/
        return check;
    }

    private void Validation(ref char Style)
    {

    }
}
