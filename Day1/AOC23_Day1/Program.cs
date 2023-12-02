class Program
{
    static void Main()
    {
        string[] input = File.ReadAllLines(@"input/input.txt");
        int sum = 0;

        foreach (string line in input)
        {
                var numericDigits = line.Where(char.IsDigit).Select(digit => int.Parse(digit.ToString()));
                if (numericDigits.Any())
                {
                    int calibrationValue = numericDigits.First() * 10 + numericDigits.Last();
                    sum += calibrationValue;
                    Console.WriteLine($"Line: {line}, Numeric Digits: {string.Join(", ", numericDigits)}, Calibration Value: {calibrationValue}");
                }
        }
        Console.WriteLine($"Sum of Calibration Values: {sum}");
        Console.ReadLine();
    }
}
