using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string happyBirthdayMessage = @"╮╭╭╮┏╮┏╮╮╭
┣┫┣┫┣╯┣╯╰┫  ☆
╯╯╯╯╯╯╯╯╰╯╭━┻━╮
┏╮┊┏╮╭╮╮╭╭┻━━━┻╮
┣┫┊┃┃┣┫╰┫┣╮╭╮╭╮┃
┗╯┊┗╯╯╯╰╯┃╰╯╰╯╰┫
━━━━━━━━━╯╳╳╳╳╳╰";

            // Collect the user's birthday
            Console.WriteLine("Enter your birthday (mm/dd/yyyy)");
            string userBirthday = Console.ReadLine();

            // Parse the input string into a DateTime object for comparison
            DateTime birthdayDT = DateTime.Parse(userBirthday);

            // Get the current date
            DateTime today = DateTime.Today;

            // Compare month and day of user's birthday and today. 
            bool isBirthday = (birthdayDT.Month == today.Month) && (birthdayDT.Day == today.Day);

            // if they are the same, print Happy Birthday ASCII message
            if (isBirthday)
            {
                Console.WriteLine(happyBirthdayMessage);
            }
            else
            {
                // Otherwise, calculate how many days are left until their birthday and print the results.
                int daysUntilBirthday;
                DateTime nextBirthday = birthdayDT.AddYears(today.Year - birthdayDT.Year);
                if (nextBirthday < today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                daysUntilBirthday = (nextBirthday - today).Days;

                Console.WriteLine($"There are {daysUntilBirthday} days left until your birthday.");
            }

        }
    }
}
