using System;
namespace GradeFinderConsoleApp
{
    class Program
    {
        public static string ObtainedNumber;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Marks: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetGrade(grade));
               
            }
                
            

        }

        public static string GetGrade(int numberOfSub)
        {
            if (numberOfSub >= 0 && numberOfSub <= 100)
            {
                if (numberOfSub >= 80 && numberOfSub <= 100)
                {
                    ObtainedNumber = "A+";
                    //Console.WriteLine("Your Grade is: " + ObtainedNumber);
                }
                else if (numberOfSub >= 70 && numberOfSub <= 79)
                {
                    ObtainedNumber = "A";
                    //Console.WriteLine("Your Grade is: " + ObtainedNumber);
                }
                else if (numberOfSub >= 60 && numberOfSub <= 69)
                {
                    ObtainedNumber = "A-";
                    //Console.WriteLine("Your Grade is: " + ObtainedNumber);
                }
                else if (numberOfSub >= 50 && numberOfSub <= 59)
                {
                    ObtainedNumber = "B+";
                    //Console.WriteLine("Your Grade is: " + ObtainedNumber);
                }
                else if (numberOfSub >= 40 && numberOfSub <= 49)
                {
                    ObtainedNumber = "B";
                    //Console.WriteLine("Your Grade is: " + ObtainedNumber);
                }
                else
                {
                    ObtainedNumber = "F";
                    //Console.WriteLine("Your Grade is: " + ObtainedNumber);
                }
            }
            else
            {
                Console.WriteLine("Please Insert Number Between 0 to 100");
            }
            
            return ("Your Grade is: " + ObtainedNumber); 
            
        }
    }
}
