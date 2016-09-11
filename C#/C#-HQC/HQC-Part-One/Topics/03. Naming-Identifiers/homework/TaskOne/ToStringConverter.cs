using System;

public class ToStringConverter
{
    public void FromBoolToString(bool variable)
    {
        var variableToString = variable.ToString();

        Console.WriteLine(variableToString);
    }
}