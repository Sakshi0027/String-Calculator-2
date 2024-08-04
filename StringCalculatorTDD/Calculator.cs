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
                var num = 2;
                return num;
            }
        }
    }
}