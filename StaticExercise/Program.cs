namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"32 deg Fahrenheit is equal to {TempConverter.FahrenheitToCelsius(32)} deg Celsius.");
            Console.WriteLine($"212 deg Fahrenheit is equal to {TempConverter.FahrenheitToCelsius(212)} deg Celsius.");
            Console.WriteLine($"0 deg Celsius is equal to {TempConverter.CelsiusToFahrenheit(0)} deg Fahrenheit.");
            Console.WriteLine($"100 deg Celsius is equal to {TempConverter.CelsiusToFahrenheit(100)} deg Fahrenheit.");

            
            // The following line did not work, as was expected.
            //TempConverter compileMe = new TempConverter();



        }
    }
}
