using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTime.Terminal
{
    class Program
    {
        /// <summary>
        /// Get all of the XML adventure files in the directory
        /// </summary>
        /// <returns>A string array of adventures</returns>
        static string[] GetAvailableAdventures()
        {
            List<string> results = new List<string>();

            // Get all of the files in the adventures folder
            string[] files = System.IO.Directory.GetFiles("Adventures");

            // Loop through and only add the XMl files to the results list
            foreach (string fileName in files)
            {
                if (fileName.Contains(".xml"))
                {
                    string nameOnly = System.IO.Path.GetFileNameWithoutExtension(fileName);
                    results.Add(nameOnly);
                }
            }

            // Return out lovely files as an array to make it simplier
            return results.ToArray();
        }
        
        /// <summary>
        /// Let the user input a number index
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static int GetUserSelectedAdventureIndex(string message)
        {
            // Write out message if there is one
            if (string.IsNullOrWhiteSpace(message) == false)
                Console.WriteLine(message);

            // Take the user input
            string userInput = Console.ReadLine();

            // Parse it into an int if possible!
            int parsedUserInput = new int();
            bool passed = int.TryParse(userInput, out parsedUserInput);

            // If the nmber is a numebr return it else call this function again until the passes in a number
            if (passed)
                return parsedUserInput;
            else
                return GetUserSelectedAdventureIndex("Invalid number, please try again");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adventure Time!");
            Console.WriteLine("Please enter an Adventure id:");

            // Get avail adventures
            string[] availableAdventures = GetAvailableAdventures();

            // Diplay to the user
            for(int counter = 0; counter < availableAdventures.Length; counter++)
            {
                Console.WriteLine(counter + ": " + availableAdventures[counter]);
            }

            // Let the user select the adventure
            int userAdventureIndex = GetUserSelectedAdventureIndex("");

            while(userAdventureIndex < 0 || userAdventureIndex >= availableAdventures.Length)
            {
                userAdventureIndex = GetUserSelectedAdventureIndex("Number is outside of the available adventure indexs");
            }

            // Now we have got a valid index, get the adventure name
            string selectedAdventureName = availableAdventures[userAdventureIndex];
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have selected the " + selectedAdventureName + " adventure!");

            // Stop the window from closing
            Console.ReadLine();
        }
    }
}
