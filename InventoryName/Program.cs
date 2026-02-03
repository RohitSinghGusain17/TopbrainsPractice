using System;
using System.Text;
using System.Globalization;

namespace InventoryNameCleanup
{
    public class Program
    {
        public static void Main()
        {
            string input = " llapppptop bag ";
            string result = CleanInventoryName(input);

            Console.WriteLine(result);
        }

        public static string CleanInventoryName(string productName)
        {
            if (productName == null)
                throw new ArgumentNullException(nameof(productName));

            // Step 1: Trim leading and trailing spaces
            productName = productName.Trim();

            // Step 2: Remove duplicate consecutive characters
            StringBuilder cleaned = new StringBuilder();
            char previousChar = '\0';

            foreach (char currentChar in productName)
            {
                if (currentChar != previousChar)
                {
                    cleaned.Append(currentChar);
                    previousChar = currentChar;
                }
            }

            // Step 3: Normalize spaces (remove extra spaces between words)
            string normalized = string.Join(
                " ",
                cleaned.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            );

            // Step 4: Convert to Title Case
            TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
            return textInfo.ToTitleCase(normalized.ToLower());
        }
    }
}