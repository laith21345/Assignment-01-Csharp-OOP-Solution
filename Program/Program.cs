using System;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main()
        {

            #region Q1
            //1- Create an Enum called "WeekDays" with the days of the week(Monday to Sunday) as its
            //   members.Then, write a C# program that prints out all the days of the week using this
            //   Enum.

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion

            #region Q2
            //2- Create an Enum called "Seasons" with the four seasons(Spring, Summer, Autumn, Winter)
            //   as its members.
            //   Write a C# program that takes a season name as input from the user and displays the
            //   corresponding month range for that season.
            //
            //   Note range for seasons ( spring march to may , summer june to august ,
            //   autumn September to November , winter December to February)

            //Seasons inputSeason = Enum.Parse<Seasons>(Console.ReadLine());

            //string monthRange = inputSeason switch
            //{
            //    Seasons.Spring => "March to May",
            //    Seasons.Summer => "June to August",
            //    Seasons.Autumn => "September to November",
            //    Seasons.Winter => "December to February",
            //};

            //Console.WriteLine(monthRange);

            #endregion

            #region Q3
            //3- Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //   Create Variable from previous Enum to Add and Remove Permission from variable,
            //   check if specific Permission existed inside variable

            ////Add
            //Permissions userPermissions = Permissions.Read | Permissions.Write;
            ////Deny write
            //if ((Permissions.Write & userPermissions) == Permissions.Write)
            //{
            //    userPermissions ^= Permissions.Write;
            //}
            //string message = (Permissions.Write & userPermissions) == Permissions.Write ?
            //                 "has Write" : "doesn't have Write";
            //Console.WriteLine(message);

            #endregion

            #region Q4
            //4- Create an Enum called "PrimaryColors" with the basic colors(Red, Green, Blue) as its members.
            //   Write a C# program that takes a color name as input from the user and displays
            //   a message indicating whether the input color is a primary color or not.

            //PrimaryColors primaryColors = new PrimaryColors();

            //bool isParsed = Enum.TryParse<PrimaryColors>(Console.ReadLine(), out PrimaryColors _);

            //Console.WriteLine(isParsed ? "primary" : "not");

            #endregion
        }
    }
}
