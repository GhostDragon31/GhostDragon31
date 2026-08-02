Random dice = new Random();
bool keepRolling = true;

while (keepRolling == true)
{
    //Title Screen
    Console.WriteLine("\nWelcome to the D&D Dice Roller!");
    Console.WriteLine("This program will roll a d4, d6, d8, d10, d12, d20, and d100 for you.\n");
    Console.WriteLine("Which die would you like to roll?");

    Console.WriteLine();

    Console.WriteLine("1. d4 -- Roll a d4 or more");
    Console.WriteLine("2. d6 -- Roll a d6 or more");
    Console.WriteLine("3. d8 -- Roll a d8 or more");
    Console.WriteLine("4. d10 -- Roll a d10 or more");
    Console.WriteLine("5. d12 -- Roll a d12 or more");
    Console.WriteLine("6. d100 -- Roll a d100 or more");
    Console.WriteLine("7. d20 -- Roll one or two d20s");
    Console.WriteLine("8. Exit D&D Dice Roller");

    Console.WriteLine();
    
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int whichDice))
    {
        Console.WriteLine("Invalid input.");
        return;
    }

    switch (whichDice) {

        //D4
        case 1:
            Console.WriteLine("\nHow many d4 would you like to roll?");
            String? howManyDice = Console.ReadLine();
            string? reRoll = "";
        
            for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
            {
                int dice_number = dice.Next(1, 5);
                Console.WriteLine("\nDice result: " + dice_number);
            }
            
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y")
            {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
                {
                    int dice_number = dice.Next(1, 5);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n")
            {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");

            String? rollAgain = Console.ReadLine();
            if (rollAgain == "y")
            {
                keepRolling = true;
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
            }
        break;

        //D6
        case 2:
            Console.WriteLine("\nHow many d6 would you like to roll?");
            howManyDice = Console.ReadLine();
            reRoll = "";
        
            for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
            {
                int dice_number = dice.Next(1, 7);
                Console.WriteLine("\nDice result: " + dice_number);
            }
            
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();

                while (reRoll == "y") {
                    Console.WriteLine("\nRe-rolling...");
                    keepRolling = true;
                    reRoll = "";
                    for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
                    {
                        int dice_number = dice.Next(1, 7);
                        Console.WriteLine("\nDice result: " + dice_number);
                    }
                
                    Console.WriteLine("\nWould you like to re-roll? (y/n)");
                    reRoll = Console.ReadLine();
                }
            
                if (reRoll == "n")
                {
                Console.WriteLine("\nYou have chosen not to re-roll.");
                }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");

            rollAgain = Console.ReadLine();
            if (rollAgain == "y")
            {
                keepRolling = true;
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
            }
        break;

        //D8
        case 3:
            Console.WriteLine("\nHow many d8 would you like to roll?");
            howManyDice = Console.ReadLine();
            reRoll = "";
        
            for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
            {
                int dice_number = dice.Next(1, 9);
                Console.WriteLine("\nDice result: " + dice_number);
            }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();

            while (reRoll == "y")
            {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
                {
                    int dice_number = dice.Next(1, 9);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n")
            {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");

            rollAgain = Console.ReadLine();
            if (rollAgain == "y")
            {
                keepRolling = true;
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
            }
        break;

        //D10
        case 4:
            Console.WriteLine("\nHow many d10 would you like to roll?");
            howManyDice = Console.ReadLine();
            reRoll = "";
        
            for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
            {
                int dice_number = dice.Next(0, 11);
                Console.WriteLine("\nDice result: " + dice_number);
            }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y")
            {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(0, 11);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n")
            {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");

            rollAgain = Console.ReadLine();
            if (rollAgain == "y")
            {
                keepRolling = true;
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
            }
        break;

        //D12
        case 5:
            Console.WriteLine("\nHow many d12 would you like to roll?");
            howManyDice = Console.ReadLine();
            reRoll = "";
        
            for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
            {
                int dice_number = dice.Next(1, 13);
                Console.WriteLine("\nDice result: " + dice_number);
            }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y")
            {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(1, 13);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");

            rollAgain = Console.ReadLine();
            if (rollAgain == "y")
            {
                keepRolling = true;
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
            }
        break;

        //D100
        case 6:
            Console.WriteLine("\nHow many d100 would you like to roll?");
            howManyDice = Console.ReadLine();
            var d100Results = new List<int> {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            reRoll = "";

            for (int i = 0; i < Convert.ToInt32(howManyDice); i++)
            { 
                int dice_number = d100Results.OrderBy(x => dice.Next()).First();
                Console.WriteLine("\nDice results: " + dice_number);
            }
            
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y")
            {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) { 
                    int dice_number = d100Results.OrderBy(x => dice.Next()).First();
                    Console.WriteLine("\nDice results: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }

            if (reRoll == "n")
            {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");
            rollAgain = Console.ReadLine();
            if (rollAgain == "y")
            {
                keepRolling = true;
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
            }
        break;

        case 7:
            Console.WriteLine("\nHow many d20 would you like to roll? 1 or 2?");
            int? howManyDice20 = Convert.ToInt32(Console.ReadLine());
            string AdvantageDisadvantage = "None";
            reRoll = "";
       
            for (int i = 0; i < howManyDice20; i++)
            {
            
                if (howManyDice20 >= 2)
                {
                
                    Console.WriteLine("\nAdvantage or Disadvantage?");
                    AdvantageDisadvantage = Console.ReadLine() ?? "";

                    if ((AdvantageDisadvantage == "Advantage") || (AdvantageDisadvantage == "advantage") || (AdvantageDisadvantage == "a") || (AdvantageDisadvantage == "A") || (AdvantageDisadvantage == "add"))
                    {

                        D20AdvantageDice2();

                        Console.WriteLine("\nWould you like to re-roll? (y/n)");
                        reRoll = Console.ReadLine();

                        while (reRoll == "y")
                        {
                            Console.WriteLine("\nRe-rolling...");
                            keepRolling = true;
                            AdvantageDisadvantage = "Advantage";
                            reRoll = "";

                            D20AdvantageDice2();

                            Console.WriteLine("\nWould you like to re-roll? (y/n)");
                            reRoll = Console.ReadLine();
                        }

                        if (reRoll == "n")
                        {
                            Console.WriteLine("\nYou have chosen not to re-roll.");
                            reRoll = "";
                            AdvantageDisadvantage = "None";
                            howManyDice20 = 0;
                        }
                    }
                    else if ((AdvantageDisadvantage == "Disadvantage") || (AdvantageDisadvantage == "disadvantage") || (AdvantageDisadvantage == "d") || (AdvantageDisadvantage == "D") || (AdvantageDisadvantage == "dis"))
                    {

                        D20DisadvantageDice2();

                        Console.WriteLine("\nWould you like to re-roll? (y/n)");
                        reRoll = Console.ReadLine();

                        while (reRoll == "y")
                        {
                            Console.WriteLine("\nRe-rolling...");
                            keepRolling = true;
                            AdvantageDisadvantage = "Disadvantage";
                            reRoll = "";
                            
                            D20DisadvantageDice2();

                            Console.WriteLine("\nWould you like to re-roll? (y/n)");
                            reRoll = Console.ReadLine();
                        }

                        if (reRoll == "n")
                        {
                            Console.WriteLine("\nYou have chosen not to re-roll.");
                            reRoll = "";
                            AdvantageDisadvantage = "";
                            howManyDice20 = 0;
                        }
                    }
                }
                else if (howManyDice20 == 1)
                {
                    
                    D20Rolling();

                    Console.WriteLine("\nWould you like to re-roll? (y/n)");
                    reRoll = Console.ReadLine();

                    while (reRoll == "y")
                    {
                        Console.WriteLine("\nRe-rolling...");
                        keepRolling = true;
                        reRoll = "";
                        
                        D20Rolling();

                        Console.WriteLine("\nWould you like to re-roll? (y/n)");
                        reRoll = Console.ReadLine();
                    }

                    if (reRoll == "n")
                    {
                        Console.WriteLine("\nYou have chosen not to re-roll.");
                        reRoll = "";
                        AdvantageDisadvantage = "None";
                        howManyDice20 = 0;
                    }
                }   
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");
            rollAgain = Console.ReadLine();

            if (rollAgain == "y")
            {
                keepRolling = true;
                AdvantageDisadvantage = "None";
            }
            else if (rollAgain == "n")
            {
                keepRolling = false;
                AdvantageDisadvantage = "None";
            }
        break;

        case 8:
        keepRolling = false;
        break;
    }
}

while (keepRolling == false)
{
    Console.WriteLine("\nThank you for using the D&D Dice Roller!\nGood luck out there adventurer!\n");
    keepRolling = true;
}

void D20AdvantageDice2()
{
    int dice_number1 = dice.Next(1, 21);
    int dice_number2 = dice.Next(1, 21);
    int largerValue;

    Console.WriteLine("\nDice results: " + dice_number1 + " and " + dice_number2);

    largerValue = System.Math.Max(dice_number1, dice_number2);

    Console.WriteLine("\nThe larger value is: " + largerValue);

    if (largerValue == 20)
    {
        Console.WriteLine("\nCritical Hit!");
    } 
                    
    if (largerValue == 1)
    {
        Console.WriteLine("\nCritical Miss!");
    }
}

void D20DisadvantageDice2()
{
    int dice_number1 = dice.Next(1, 21);
    int dice_number2 = dice.Next(1, 21);
    int smallerValue;

    Console.WriteLine("\nDice results: " + dice_number1 + " and " + dice_number2);

    smallerValue = System.Math.Min(dice_number1, dice_number2);            
                    
    Console.WriteLine("\nThe smaller value is: " + smallerValue);

    if (smallerValue == 20)
    {
        Console.WriteLine("\nCritical Hit!");
    } 
                    
    if (smallerValue == 1)
    {
        Console.WriteLine("\nCritical Miss!");
    }
}

void D20Rolling()
{
    int dice_number = dice.Next(1, 21);
    Console.WriteLine("\nDice results: " + dice_number);

    if (dice_number == 20)
    {
        Console.WriteLine("\nCritical Hit!");
    }

    if (dice_number == 1)
    {
        Console.WriteLine("\nCritical Miss!");
    }

}