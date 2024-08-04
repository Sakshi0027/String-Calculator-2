using System.Net.NetworkInformation;
using Calculator;

namespace StringCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new SetCalculator();
            var text = calc.readText();

            var result = calc.add(text);

            Console.WriteLine("The final result is " + result);
        }
    }
}

