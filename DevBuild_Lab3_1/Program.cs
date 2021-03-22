using System;

namespace DevBuild_Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Lab 3.1!");

            string[] studentName = { "George", "Miranda", "Isaac", "Chancelor" };
            string[] studentFavFood = { "Pizza", "Tacos", "Cheeseburgers", "Wings" };
            string[] studentPrevTitle = { "King", "Dutchess", "Prince", "Governor" };

            int studentInfo = 0;
            bool invalidStudName = true;
            bool invalidUserRequest = true;
            bool anotherStudent = true;
            string chosenStudent;
            string userRequestStudHistory;
            string moreInfoAnotherStud;

            do
            {
                do
                {
                    Console.WriteLine("\nWhich student would you like to know about?");
                    chosenStudent = Console.ReadLine().ToUpper();


                    if (chosenStudent == "GEORGE" || chosenStudent == "MIRANDA" || chosenStudent == "ISAAC" || chosenStudent == "CHANCELOR")
                    {
                        invalidStudName = false;
                    }

                    else
                    {
                        Console.WriteLine("\nPlease enter a valid student name from the below list:");

                        for (int i = 0; i <= studentName.Length - 1; i++)
                        {
                            Console.WriteLine($"{studentName[i]}");
                        }

                    }
                } while (invalidStudName);

                if (chosenStudent == "GEORGE") //Verify Here
                {
                    studentInfo = 0;

                }

                else if (chosenStudent == "MIRANDA")
                {
                    studentInfo = 1;
                }

                else if (chosenStudent == "ISAAC")
                {
                    studentInfo = 2;
                }

                else if (chosenStudent == "CHANCELOR")
                {
                    studentInfo = 3;
                }

                do
                {
                    Console.WriteLine($"\nWhat would you like to know about {chosenStudent}?");
                    userRequestStudHistory = Console.ReadLine().ToUpper();

                    if (userRequestStudHistory == "FOOD" || userRequestStudHistory == "TITLE")
                    {
                        invalidUserRequest = false;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid student request from the below list:\nFood \nTitle");
                    }

                } while (invalidUserRequest);

                if (userRequestStudHistory == "FOOD") //Verify Here
                {
                    Console.WriteLine($"{studentName[studentInfo]} likes {studentFavFood[studentInfo]}");
                }

                else if (userRequestStudHistory == "TITLE")
                {
                    Console.WriteLine($"{studentName[studentInfo]}'s previous title was a(n) {studentPrevTitle[studentInfo]}");
                }

                
                    Console.WriteLine("\nWould you like to learn more about another student? \nPress Enter to continue or type No or N to exit");
                    moreInfoAnotherStud = Console.ReadLine().ToUpper();

                    if (moreInfoAnotherStud == "NO" || moreInfoAnotherStud == "N")
                    {
                        anotherStudent = false;
                    }
                
            } while (anotherStudent);

        }

    }
}
