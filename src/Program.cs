Temperature temp1 = new(32, 'f');
Console.WriteLine("converted:" + temp1.Convertor());

Temperature temp2 = new(100, 'c');
Console.WriteLine("converted:" + temp2.Convertor());

Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

Console.WriteLine("Enter a temperature and its unit (C or F)");


try
{
    double temp = Convert.ToDouble(Console.ReadLine());
    char unit = Convert.ToChar(Console.ReadLine());
    if (!unit.Equals("C") || !unit.Equals("F")) ;
    {
        Console.WriteLine(temp + unit);
        // Console.WriteLine("not supported");
        // throw new FormatException(unit + "not supported scale");
    }
    Temperature temp3 = new(temp, unit);
    Console.WriteLine("converted:" + temp3.Convertor());
}
catch (FormatException ex)
{

    Console.WriteLine(ex.Message);
}

class Temperature
{
    double temperature;
    char unit;
    public Temperature(double temp, char u)
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










