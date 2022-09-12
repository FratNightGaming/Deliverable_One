using System;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }

        static void Display()
        {
            float loaves;//should these variables be declared beforehand
            float jarsPeanutButter;//should these variables be declared beforehand
            float jarsJelly;//should these variables be declared beforehand
            int slicesPerLoaf = 28;

            Console.WriteLine("How many people are we making PB & J sandwiches for?");
            int totalSandwiches = int.Parse(Console.ReadLine());
            Console.WriteLine("\nYou said: " + totalSandwiches + "\n");

            int slicesBread = totalSandwiches * 2;
            loaves = MathF.Ceiling((float)slicesBread / slicesPerLoaf);//problem: cant use mathf or math.ceiling with two variables that, when divided, may be a float. Solution: store decimal in separate variable, THEN use math.ceiling to convert decimal to rounded int
                                                                       //loaves = (int)MathF.Ceiling(loavesDecimal);

            int tablespoonsPB = totalSandwiches * 2;
            int teaspoonsJelly = totalSandwiches * 4;

            jarsPeanutButter = MathF.Ceiling((float)tablespoonsPB / 32);//32 tbsp/jar
                                                                        //jarsPeanutButter = (int)MathF.Ceiling(jarsPeanutButterDecimal);

            jarsJelly = MathF.Ceiling((float)teaspoonsJelly / 48);//48 tsp/jar
                                                                  //jarsJelly = (int)MathF.Ceiling(jarsJellyDecimal);

            Console.WriteLine("You need:\n \n \n" + slicesBread + " slices of bread\n" + tablespoonsPB + " tablespoons of peanut butter\n" + teaspoonsJelly + " teaspoons of jelly\n\n");

            Console.WriteLine("which is...\n\n");

            Console.WriteLine(loaves + " loaves of bread\n" + jarsPeanutButter + " jars of peanut butter\n" + jarsJelly + " jars of jelly\n\n");

            RestartMessage();
        }

        static void RestartMessage()
        {
            Console.WriteLine("Would you like to restart? Enter y or yes to continue, or enter any other key to exit.");

            string userResponse = Console.ReadLine().ToUpper();

            if (userResponse == "YES" || userResponse == "Y")
            {
                Display();
            }

            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }

    /*Write a program that calculates how many loaves of bread, jars of peanut butter, and jars of jelly are needed to feed X amount of people.Ask the user how many people are being fed, calculate the amount of ingredients needed, and then print the results out to the console.

    Build Specifications

    Each sandwich requires 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly
     -Assume 1 sandwich per person
     -Assume 1 loaf of bread contains exactly 28 slices
     -Assume 1 jar of peanut butter contains exactly 32 tablespoons
     -Assume 1 jar of jelly contains exactly 48 teaspoons

    First, ask the user, “How many people are we making PB&J sandwiches for?” Expect the user to enter number.You’ll need to parse the input and store it in a number variable.

    You can now calculate the total amount of slices, tablespoons, and teaspoons needed.Print out these values to the console(see the console example below). 

    Next, calculate how many loaves are needed.The formula is totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf.But since we can't buy partial loaves, round up the answer. For example, if 1.3 loaves are needed, we need to round that up and get 2 loaves. (Hint: search online how to round numbers up in C#.)

    Do the same calculation for jars of peanut butter and jars of jelly. These also require rounding up.

    Print out all three of these totals. (again, see the console example below)

    After printing out all of the results, ask the user if they would like to start the program over.If yes, loop through the program again.If the user answers anything other than ‘y’ or “yes”, print "Goodbye" and exit the program.
    */
}
