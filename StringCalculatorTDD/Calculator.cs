namespace Calculator
{
    public class SetCalculator
    {
        public string readText()
        {
            Console.WriteLine("Add your text here:");
            string text = Console.ReadLine();
            return text;
        }
        public int add(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                string delimiter = ",";
                string numbersPart = input;

                // Check for custom delimiter
                if (input.StartsWith("//"))
                {
                    int delimiterEndIndex = input.IndexOf('\n');
                    if (delimiterEndIndex == -1)
                    {
                        Console.WriteLine("Invalid input format.");
                        return 0;
                    }
                    delimiter = input.Substring(2, delimiterEndIndex - 2);
                    numbersPart = input.Substring(delimiterEndIndex + 1);
                }

                // Split the numbers using the custom delimiter and new lines
                string[] delimiters = new string[] { delimiter, "\n" };
                string[] numbers = numbersPart.Split(delimiters, StringSplitOptions.None);
                int sum = 0;

                foreach (string number in numbers)
                {
                    if (!string.IsNullOrWhiteSpace(number))
                    {
                        if (int.TryParse(number.Trim(), out int parsedNumber))
                        {
                            sum += parsedNumber;
                        }
                    }
                }
                
                return sum;
            }
        }
    }
}