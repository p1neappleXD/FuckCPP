using System; //scope.

namespace Program //project name maybe idfk.
{
    class Program //scope? maybe? i'm so clueless. why am i here typing a whole ass narrative like an autist? no one's going to see this.
    {
        static void Main(string[] args) //i don't know wtf this does, i just got into c# coding yesterday.
        {
            int times; //reserved totals variable.
            int speed; //reserved intervals speed variable.
            Console.WriteLine("Welcome to Fuck C++ v1.3, written entirely in C#."); //version.
            Console.WriteLine(""); //space for readability.
            Console.WriteLine("Disclaimer: No values can be 0 or under."); //disclaimer.
            Console.WriteLine(""); //space for readability.
            Console.WriteLine("Input the amount of times you want to fuck C++:"); //do i need to explain this.
            string inputTimes = Console.ReadLine(); //user input.
            times = Convert.ToInt32(inputTimes); //conversion from string to int.
            if (times <= 0) // 0 or under breaks the program.
            {
                Console.WriteLine("Are you trying to break my shit? No O or under."); //that's what you get for not listening to the disclaimer.
                Environment.Exit(0); // 0 or under ends the program.
            }
            Console.WriteLine(""); //space for readability.
            Console.WriteLine("Input the speed of your C++ fucking (lower value is less time per interval in milliseconds):"); //milliseconds per interval.
            string inputSpeed = Console.ReadLine(); //user input.
            speed = Convert.ToInt32(inputSpeed); //conversion from string to int.
            if (speed <= 0) //0 or under breaks the program.
            {
                Console.WriteLine("Bitch are you dumb? I said no 0 or under."); //that's what you get for not listening to the disclaimer.
                Environment.Exit(0); // 0 or under ends the program.
            }

            for (int i = 0; i <= times; i++) //for loop, adds 1 per loop.
            {
                if (i <= times) //i forgot what this does.
                {
                    Thread.Sleep(speed); //delay between intervals depending on user input.
                    Console.WriteLine("Fuck C++"); //because fuck c++.
                }
            }
            Console.WriteLine(""); //space for readability.
            Console.WriteLine("Thank you for using my program you based C# enjoyer, you can now exit the program by pressing ENTER."); //thanks and exit guide.
            Console.ReadLine(); //to make the program not end itself without pressing ENTER.
        }
    }
}
