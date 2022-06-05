// See https://aka.ms/new-console-template for more informatio Azn=0;

//    string[] currency = { "USD", "RUB", "TRY" };
//    float[] currencyvalue = { 1.700f, 0.0271f, 0.1031f };
//    string[] commandBox = { "show recent currency rates", "find currency rate by code", "calculate amount by currency", "exit" };
//    int indexCurrency = 0;
//int indexcurrencyvalue = 0;
//    int indexCommand = 0;
//    float oneUsd = 1.700f;
//    float oneRub = 0.0271f;
//    float oneTry = 0.1031f;

//    for (int i = 0; i < commandBox.Length; i++)
//    {
//        Console.WriteLine(commandBox[i]);
//    }
//while (true)
//{


//    Console.Write("Choose the command: "); string requiredCommand = Console.ReadLine();


//    if (requiredCommand == commandBox[0])
//    {
//        Console.WriteLine("1 USD = " + oneUsd + " AZN");
//        Console.WriteLine("1 RUB = " + oneRub + " AZN");
//        Console.WriteLine("1 TRY = " + oneTry + " AZN");

//    }
//    if (requiredCommand == commandBox[1])
//    {
//        Console.Write("Choose the currency : "); string requiredCurrency = Console.ReadLine();
//        if (requiredCurrency == currency[0])
//        {
//            Console.WriteLine(currencyvalue[0] + " AZN");
//        }
//        if (requiredCurrency == currency[1])
//        {
//            Console.WriteLine(currencyvalue[1] + " AZN");
//        }
//        if (requiredCurrency == currency[2])
//        {
//            Console.WriteLine(currencyvalue[2] + " AZN");
//        }
//    }    
//}



string[] commandBox = { "show recent currency rates", "find currency rate by code", "calculate amount by currency", "exit" };
string[] currency = { "USD", "RUB", "TRY" };
float[] currencyvalue = { 1.700f, 0.0271f, 0.1031f };
int indexcommandbox = 0;
int indexcurrency = 0;
int indexcurrencyvalue = 0;
double number = 0;

    float oneUsd = 1.700f;
    float oneRub = 0.0271f;
    float oneTry = 0.1031f;

while (true)
{

    while (indexcommandbox < commandBox.Length)
    {
        Console.WriteLine(commandBox[indexcommandbox]);
        indexcommandbox++;

    }

    Console.Write($"Choose the command : "); string requiredCommand = Console.ReadLine();
    if (requiredCommand == commandBox[0])
    {
        Console.WriteLine("1 USD = " + oneUsd + " AZN");
        Console.WriteLine("1 RUB = " + oneRub + " AZN");
        Console.WriteLine("1 TRY = " + oneTry + " AZN");
    }
    if (requiredCommand == commandBox[1])
    {
        Console.Write($"Find currency : "); string requiredCureency = Console.ReadLine();
        if (requiredCureency == currency[0])
        {
            Console.WriteLine("1 USD = " + oneUsd + " AZN");
        }
        if (requiredCureency == currency[1])
        {
            Console.WriteLine("1 RUB = " + oneRub + " AZN");
        }
        if (requiredCureency == currency[2])
        {
            Console.WriteLine("1 TRY = " + oneTry + " AZN");
        }
    }

    if (requiredCommand == commandBox[2])
    {
        Console.Write($"Enter amount : (AZN) "); double requiredAZN = Convert.ToDouble(Console.ReadLine());
        while (number <= 1000)
        {
            if (requiredAZN == number)
            {
                Console.WriteLine(0.5882* requiredAZN + " (USD)");
                Console.WriteLine(36.9003 * requiredAZN + " (RUB)");
                Console.WriteLine(9.6993 * requiredAZN + " (TRY)");
            }
            number++;
        }

    }
    
}























