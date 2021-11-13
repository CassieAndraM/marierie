using System;

namespace demo1
{

 class Program
{
    static void Main(string[] args)
        {
            Console.WriteLine("Employee Time Keeping System");
            Console.WriteLine($"Today's Date: {DateTime.Today.ToShortDateString()}");

            Console.Write("To log your time-in enter your employee id: ");
            string employeeId = Console.ReadLine();

            //Date and Time --> DateTime
            //Time only --> TimeSpan

            TimeSpan timeIn = new TimeSpan(8, 0, 0);
            Console.WriteLine($"Your login time is recorded: {timeIn}");

            Console.WriteLine("**************************************");
            Console.Write("To log your time-out enter employee id: ");
            employeeId = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(17, 0, 0);
            Console.WriteLine($"Your logout time is recorded: {timeOut}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;


            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(19, 30, 0);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0, 0, 0);

            if (timeIn > regularHoursStart)
            {
                lateIn = timeIn - regularHoursStart;
            }

            if (timeOut < regularHoursEnd)
            {
                earlyOut = timeOut - regularHoursEnd;
            }

            Console.WriteLine($"Your total regular hours worked is: {totalHours}");

            TimeSpan totalRegularHours = totalHours - (lateIn + earlyOut);
            Console.WriteLine($"Your total hours worked is: {totalRegularHours}");

            TimeSpan totalOvertimeHours = regularHoursEnd - timeOut;
                Console.WriteLine($"Your total overtime hours is: {totalOvertimeHours}");
        }
    }
}

/* Windows PowerShell
Copyright (C) Microsoft Corporation. All rights reserved.

Try the new cross-platform PowerShell https://aka.ms/pscore6

PS C:\Users\cassandra\Desktop\demo1> cd "c:\Users\cassandra\Desktop\demo1\" ; if ($?) { dotnet run Program.cs }
Employee Time Keeping System
Today's Date: 13/11/2021
To log your time-in enter your employee id: 12345
Your login time is recorded: 08:00:00
**************************************
To log your time-out enter employee id: 12345
Your logout time is recorded: 17:00:00
Your total regular hours worked is: 08:00:00
Your total hours worked is: 10:30:00
Your total overtime hours is: 02:30:00
PS C:\Users\cassandra\Desktop\demo1>
*/