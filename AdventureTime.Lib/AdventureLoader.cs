using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTime.Lib
{
    public static class AdventureLoader
    {
        /// <summary>
        /// Get all of the XML adventure files in the directory
        /// </summary>
        /// <returns>A string array of adventures</returns>
        public static string[] GetAvailableAdventures()
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
    }
}
