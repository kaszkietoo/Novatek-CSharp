using System;
using System.Text;

namespace Novatek._5A
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2020;                        
            
            for (int month = 1; month <= 12; month++)
            {
                for (int day = 1; day <= DateTime.DaysInMonth(year, month); day++)
                {
                    Console.WriteLine(GetCompleteString(day, month, year));
                }
            }
        }

        static string GetCompleteString(int day, int month, int year)
        {
            int sum = 0;
            string sDay = day.ToString("00");
            string sMonth = month.ToString("00");            

            sum = int.Parse(sDay[0].ToString()) + int.Parse(sDay[1].ToString())
                  + int.Parse(sMonth[0].ToString()) + int.Parse(sMonth[1].ToString()) + 2 + 2;

            sum *= day;

            return string.Format("{0:00}.{1:00}.{2} = {3}", day, month, year, sum);
        }
    }
}
