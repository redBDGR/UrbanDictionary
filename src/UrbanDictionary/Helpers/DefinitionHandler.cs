using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanDictionary
{
    public class DefinitionHandler
    {
        public static Definition FindBestDefinition(DefinitionList list, string searchTerm)
        {
            foreach (Definition definition in list.definitions)
            {
                if (definition.word == searchTerm)
                    return definition;
            }

            return null;
        }

        public static string Format(string input)
        {
            SetEncoding(ref input);

            string final = "";

            // Removes characters left from URLs from the webpage (not the best way to do this but i gave up and cheated)
            foreach(char _char in input)
            {
                if (_char == '[' || _char == ']')
                    continue;
                final += _char;
            }

            return final;
        }

        private static void SetEncoding(ref string input)
        {
            Encoding.UTF8.GetString(Encoding.Default.GetBytes(input));
        }
    }
}
