using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace UrbanDictionary
{
    public class Lookup
    {
        // Main method for looking up a string on UrbanDictionary
        public static DefinitionList LookupDefinitions(string searchTerm)
        {
            // Initial response from the website
            string response = null;

            try
            {
                // Simple webrequest
                using (var request = new WebClient())
                {
                    response = request.DownloadString("http://api.urbandictionary.com/v0/define?term=" + "\"" + searchTerm + "\"");
                }
            }

            // If webrequest fails or returns nothing 
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.ToString(), "There was an error contacting a dictionary", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error, System.Windows.MessageBoxResult.OK);
            }

            // Check that the response is valid and not empty
            if (response == null || response == "")
            {
                System.Windows.MessageBox.Show("Could not connect to a dictionary", "Error!", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error, System.Windows.MessageBoxResult.OK);
            }

            // Convert response to an actual object
            DefinitionList list = ConvertToDefinitionList(response);

            // Check if there were at least one definition returned
            if (list.definitions.Count == 0)
            {
                System.Windows.MessageBox.Show("No definitions were found!", "Error!", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error, System.Windows.MessageBoxResult.OK);
            }

            return list;
        }

        private static DefinitionList ConvertToDefinitionList(string response)
        {
            return JsonConvert.DeserializeObject<DefinitionList>(response);
        }
    }
}
