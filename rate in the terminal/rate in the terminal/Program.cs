while (true)
{
    Console.WriteLine();
    Console.WriteLine("/show-recent-currency-rates");
    Console.WriteLine("/find-currency-rate-by-code");
    Console.WriteLine("/calculate-amount-by-currecy");
    Console.WriteLine("/exit");
    Console.WriteLine();
    Console.Write("Choose the command : ");
    string requiredCommand = Console.ReadLine();
    string[] currency = { "USD", "EUR", "TRY" };
    double[] currencyRate = { 1.7, 1.8161, 0.1022 };
    if (requiredCommand == "/show-recent-currency-rates")
    {
        for (int i = 0; i < currency.Length; i++)
        {
            Console.WriteLine("Currently Currency : " + currency[i] + "   Currently Currency Rate : " + currencyRate[i]);
        }
    }
    else if (requiredCommand == "/find-currency-rate-by-code")
    {
        Console.Write("Please select your Currency : ");
        string requiredCurrency = Console.ReadLine();
        bool isRequiredCurrency = true;
        for (int i = 0; i < currency.Length; i++)
        {
            if (requiredCurrency == currency[i])
            {
                Console.WriteLine("Currently Currency : " + currency[i] + "   Currently Currency Rate : " + currencyRate[i]);
                isRequiredCurrency = false;
            }
        }
        if (isRequiredCurrency)
        {
            Console.WriteLine("Your Currency Code not found : " + requiredCurrency);
        }
    }
    else if (requiredCommand == "/calculate-amount-by-currecy")
    {
        double requiredCurrencyRate = 0;
        bool isRequiredCurrencyNotFound = true;
        Console.Write("Please select your Currency : "); string requiredCurrency = Console.ReadLine();
        for (int i = 0; i < currency.Length; i++)
        {

            if (requiredCurrency == currency[i])
            {
                requiredCurrencyRate=currencyRate[i];
                isRequiredCurrencyNotFound=false;
            }
        }
        if (isRequiredCurrencyNotFound)
        {
            Console.WriteLine("Currency not found : "+requiredCurrency);
            
        }
        Console.Write("Please select your Amount (AZN) : "); double requiredAmount = Convert.ToDouble(Console.ReadLine());
        if(requiredAmount >0 && requiredAmount <= 1000)
        {
                Console.WriteLine(requiredAmount / requiredCurrencyRate);
        }
        else
        {
            Console.WriteLine("Amount is not correct : " + requiredAmount);
        }
    }
    else if (requiredCommand == "/exit")
    {
        Console.WriteLine("BYE-BYE");
    }
    else
    {
        Console.WriteLine("Command not found");
    }
}


































