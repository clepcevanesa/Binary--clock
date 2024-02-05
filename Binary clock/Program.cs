using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți ora curentă (HH:MM:SS): ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime time))
        {
            int hour = time.Hour;
            int minute = time.Minute;
            int second = time.Second;

            string binaryHour = ConvertToBinary(hour, 5); // Conversie ora în binar (5 biți)
            string binaryMinute = ConvertToBinary(minute, 6); // Conversie minute în binar (6 biți)
            string binarySecond = ConvertToBinary(second, 6); // Conversie secunde în binar (6 biți)

            Console.WriteLine($"Ceasul binar: {binaryHour}:{binaryMinute}:{binarySecond}");
        }
        else
        {
            Console.WriteLine("Formatul introdus nu este valid. Introduceți ora în formatul HH:MM:SS.");
        }
    }

    // Funcție pentru conversia unui număr întreg în format binar cu lățimea specificată
    static string ConvertToBinary(int number, int width)
    {
        return Convert.ToString(number, 2).PadLeft(width, '0');
    }
}
