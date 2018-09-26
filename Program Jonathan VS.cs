

namespace ConsoleApp1
{
    class Program
    {
        // 1.full name.
        //
        static void Main(string[] args)
        {
    

            System.Console.Write("first Name : ");
            string firstname = System.Console.ReadLine();

            System.Console.Write("Middle name : ");
            string middlename = System.Console.ReadLine();

            System.Console.Write("last name : ");
            string lastname = System.Console.ReadLine();

            string fullName = firstname + " " + middlename + " " + lastname;

            System.Console.WriteLine(fullName);


            const double multiplier = 2.54;
            int inInches = 12;
            
        
            System.Console.Write("height in feet : ");
            int heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("extra inches : ");
            double heightInInches = double.Parse(System.Console.ReadLine());

            double inches = heightInInches * heightInFeet;
            inches += heightInInches;

            double centimeters = inches * multiplier;

            System.Console.WriteLine(centimeters);

            System.Console.Write("How old are you : ");
            int age = int.Parse(System.Console.ReadLine());


            System.Console.Write("Are you Citizen of America : ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote = age > 17 && isCitizen;

            System.Console.WriteLine(canVote); 










        }
    }
}
