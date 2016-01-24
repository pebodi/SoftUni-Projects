using System;

class CurrencyConverter
{
    static void Main()
    {

        var lev = 1.0;											
        var dollar = 1.79549;
        var euro = 1.95583;
        var pound = 2.53405;

        var value = double.Parse(Console.ReadLine());                    
        var inputCurrency = Console.ReadLine();                          
        var outputCurrency = Console.ReadLine();                         

        switch (inputCurrency)								 
        {
            case "BGN":
                break;
            case "USD":
                value = (value * dollar);
                break;
            case "EUR":
                value = (value * euro);
                break;
            case "GBP":
                value = (value * pound);
                break;
            default:
                break;
        }


        switch (outputCurrency)						       

        {
            case "BGN":
                value = value / lev;
                break;
            case "USD":
                value = value / dollar;
                break;
            case "EUR":
                value = value / euro;
                break;
            case "GBP":
                value = value / pound;
                break;
            default:
                break;
        }


        Console.WriteLine(Math.Round(value, 2));              			
        


    }
}