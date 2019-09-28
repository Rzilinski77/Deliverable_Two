using System;

namespace ThingsToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = 0;
            string activityType = "";
            string activity = "";
            string travelOption = ""; 
            string[] activities = { "Stock Car Racing", "To a Movie", "Ride a Rollercoaster", "To Texas de Brazil" };
            string[] travelOptions = { "sneakers", "a sedan", "a Volkswagon bus", "Multiple Cars" };
            bool repeat1 = true, repeat2 = false;
            bool ifParsed;

            Console.WriteLine("Hello user, what are you in in the mood for?");
            Console.WriteLine("Here are your options. Please select a number.");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chilling");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");
            string activitySelection = Console.ReadLine();

                while (repeat1 == true)
                {
                    if (activitySelection == "1")
                    {
                        activityType = "Action";
                        activity = activities[0];
                        repeat1 = false;
                    }
                    else if (activitySelection == "2")
                    {
                        activityType = "Chilling";
                        activity = activities[1];
                        repeat1 = false;
                    }
                    else if (activitySelection == "3")
                    {
                        activityType = "Danger";
                        activity = activities[2];
                        repeat1 = false;
                    }
                    else if (activitySelection == "4")
                    {
                        activityType = "Good Food";
                        activity = activities[3];
                        repeat1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option");
                        activitySelection = Console.ReadLine();
                    }
                }
                Console.WriteLine("How many people are you bringing with you? ex: 1");
                
                while (repeat2 == false)
                {
                    ifParsed = Int32.TryParse(Console.ReadLine(), out numberOfPeople);
                if (ifParsed == true)
                {
                    repeat2 = true;
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
            }
            if (numberOfPeople == 0)
            {
                travelOption = travelOptions[0];
                repeat2 = false;
            }
            else if (numberOfPeople > 0 && numberOfPeople < 5)
            {
                travelOption = travelOptions[1];
                repeat2 = false;
            }
            else if (numberOfPeople > 4 && numberOfPeople < 11)
            {
                travelOption = travelOptions[2];
                repeat2 = false;
            }
            else if (numberOfPeople > 10)
            {
                travelOption = travelOptions[3];
                repeat2 = false;
            }

            Console.WriteLine("Okay if you're in the mood for " + activityType + ", then you should go " + activity + " and travel in " + travelOption + "!");
                Console.WriteLine("Goodbye");
        }
    }
}
