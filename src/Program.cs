TempConvert temp1 = new(32, 'f');
Console.WriteLine("converted:" + temp1.Convertor());

TempConvert temp2 = new(100, 'c');
Console.WriteLine("converted:" + temp2.Convertor());

Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

Console.WriteLine("Enter a temperature and its unit (C or F) or 'quit' to exist");

string? input = Console.ReadLine();

while (true)
{
    try
    {   
        if (input is null || input == "" || input.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
        {
            System.Console.WriteLine("BYEEEE");
            break;
        }
        string[] info = input.Split(" ");
        string unit = info[1];
        if (unit.ToLower() == "c" || unit.ToLower() == "f")
        {
            if (double.TryParse(info[0], out double r))
            {
                double temper = double.Parse(info[0]);
                TempConvert temp3 = new(temper, char.Parse(unit.ToLower()));
                Console.WriteLine("converted:" + temp3.Convertor());
            }
            else
            {
                Console.WriteLine("YOU HAVE TO ENTER A NUMBER ONLY FOR TEPMERATURE!!!");
            }
        }
        else
        {
            Console.WriteLine("ONLY Celsius or Fahrenheit ");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        break;
    }
    Console.WriteLine("Enter a temperature and its unit (C or F)");
    input = Console.ReadLine();
    continue;
}



class TempConvert
{
    double temperature;
    char unit;
    public TempConvert(double temp, char u)
    {
        temperature = temp;
        unit = u;
    }
    public string Convertor()
    {
        double converted;
        if (unit is 'f')
        {
            converted = (temperature - 32) / (1.8);
            return converted + "c";
        }
        else if (unit is 'c')
        {
            converted = ((1.8) * temperature) + 32;
            return converted + "f";
        }
        else return "not f or c";
    }
}









