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
        public int add(string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                return 0;
            }
            else
            {
                int sum = 0;
                string[] numbers = text.Split(',');
                foreach (string num in numbers)
                {
                    sum += int.Parse(num.Trim());
                }
                
                return sum;
            }
        }
    }
}