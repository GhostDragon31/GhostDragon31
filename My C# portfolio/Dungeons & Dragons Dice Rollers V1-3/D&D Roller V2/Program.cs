/*D&D Dice Roller*/
// A dice roller for Dungeons and Dragons. Version 2. (Personal Project)

/*This is a personal project I created for D&D! This program allows you
to roll various dice, including advantage and disadvantage rolls,
more than one dice at a time and allows for re-rolls! Enjoy!*/

using System.Reflection.Metadata;

Random dice = new Random();
Boolean keepRolling = true;

//Start of loop
while (keepRolling == true) {
    Console.WriteLine("\nWelcome to the DND Dice Roller!");
    Console.WriteLine("This program will roll a d4, d6, d8, d10, d12, d20, and d100 for you.\n");
    Console.WriteLine("Which die would you like to roll?");
    String? whichDice = Console.ReadLine();

    //D6
    if (whichDice == "d6") {
        Console.WriteLine("\nHow many d6 would you like to roll?");
        String? howManyDice = Console.ReadLine();
        string? reRoll = "";
        
        for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
            int dice_number = dice.Next(1, 6);
            Console.WriteLine("\nDice result: " + dice_number);
        }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y") {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(1, 6);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

        Console.WriteLine("\nWould you like to roll another die? (y/n)");

        String? rollAgain = Console.ReadLine();
        if (rollAgain == "y") {
            keepRolling = true;
        } else if (rollAgain == "n") {
            keepRolling = false;
        }
    }

    //D4
    if (whichDice == "d4") {
        Console.WriteLine("\nHow many d4 would you like to roll?");
        String? howManyDice = Console.ReadLine();
        string? reRoll = "";
        
        for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
            int dice_number = dice.Next(1, 4);
            Console.WriteLine("\nDice result: " + dice_number);
        }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y") {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(1, 4);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

        Console.WriteLine("\nWould you like to roll another die? (y/n)");

        String? rollAgain = Console.ReadLine();
        if (rollAgain == "y") {
            keepRolling = true;
        } else if (rollAgain == "n") {
            keepRolling = false;
        }
    }

    //D8
    if (whichDice == "d8") {
        Console.WriteLine("\nHow many d8 would you like to roll?");
        String? howManyDice = Console.ReadLine();
        string? reRoll = "";
        
        for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
            int dice_number = dice.Next(1, 8);
            Console.WriteLine("\nDice result: " + dice_number);
        }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y") {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(1, 8);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

        Console.WriteLine("\nWould you like to roll another die? (y/n)");

        String? rollAgain = Console.ReadLine();
        if (rollAgain == "y") {
            keepRolling = true;
        } else if (rollAgain == "n") {
            keepRolling = false;
        }
    }

    //D10
    if (whichDice == "d10") {
        Console.WriteLine("\nHow many d10 would you like to roll?");
        String? howManyDice = Console.ReadLine();
        string? reRoll = "";
        
        for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
            int dice_number = dice.Next(0, 9);
            Console.WriteLine("\nDice result: " + dice_number);
        }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y") {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(0, 9);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

        Console.WriteLine("\nWould you like to roll another die? (y/n)");

        String? rollAgain = Console.ReadLine();
        if (rollAgain == "y") {
            keepRolling = true;
        } else if (rollAgain == "n") {
            keepRolling = false;
        }
    }

    //D12
    if (whichDice == "d12") {
        Console.WriteLine("\nHow many d12 would you like to roll?");
        String? howManyDice = Console.ReadLine();
        string? reRoll = "";
        
        for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
            int dice_number = dice.Next(1, 12);
            Console.WriteLine("\nDice result: " + dice_number);
        }
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y") {
                Console.WriteLine("\nRe-rolling...");
                keepRolling = true;
                reRoll = "";
                for (int i = 0; i < Convert.ToInt32(howManyDice); i++) {
                    int dice_number = dice.Next(1, 12);
                    Console.WriteLine("\nDice result: " + dice_number);
                }
                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();
            }
            
            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

        Console.WriteLine("\nWould you like to roll another die? (y/n)");

        String? rollAgain = Console.ReadLine();
        if (rollAgain == "y") {
            keepRolling = true;
        } else if (rollAgain == "n") {
            keepRolling = false;
        }
    }

    //D100 - Operates slightly differently than the other dice, as it rolls in groups of 10 instead.
    if (whichDice == "d100") {
        Console.WriteLine("\nHow many d100 would you like to roll?");
        String? howManyDice = Console.ReadLine();
        var d100Results = new List<int> {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
        string? reRoll = "";

        for (int i = 0; i < Convert.ToInt32(howManyDice); i++) { 
            int dice_number = d100Results.OrderBy(x => dice.Next()).First();
            Console.WriteLine("\nDice results: " + dice_number);
        }
            
            Console.WriteLine("\nWould you like to re-roll? (y/n)");
            reRoll = Console.ReadLine();

            while (reRoll == "y") {
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

            if (reRoll == "n") {
                Console.WriteLine("\nYou have chosen not to re-roll.");
            }

            Console.WriteLine("\nWould you like to roll another die? (y/n)");
            String? rollAgain = Console.ReadLine();
            if (rollAgain == "y") {
                keepRolling = true;
            } else if (rollAgain == "n") {
                keepRolling = false;
            }
    }

    //D20
    if (whichDice == "d20") {
        Console.WriteLine("\nHow many d20 would you like to roll? 1 or 2?");
        int? howManyDice20 = Convert.ToInt32(Console.ReadLine());
        string AdvantageDisadvantage = "None";
         string? reRoll = "";
       
        for (int i = 0; i < howManyDice20; i++) {
            
            if (howManyDice20 >= 2) {
                
                Console.WriteLine("\nAdvantage or Disadvantage?");
                AdvantageDisadvantage = Console.ReadLine() ?? "";

                if (AdvantageDisadvantage == "Advantage") {

                    int dice_number1 = dice.Next(1, 20);
                    int dice_number2 = dice.Next(1, 20);
                    int largerValue;

                    Console.WriteLine("\nDice results: " + dice_number1 + " and " + dice_number2);

                    largerValue = System.Math.Max(dice_number1, dice_number2);

                    Console.WriteLine("\nThe larger value is: " + largerValue);

                    if (largerValue == 20) {
                        Console.WriteLine("\nCritical Hit!");
                    } 
                    
                    if (largerValue == 1) {
                        Console.WriteLine("\nCritical Miss!");
                    }

                    Console.WriteLine("\nWould you like to re-roll? (y/n)");
                    reRoll = Console.ReadLine();

                    while (reRoll == "y") {
                        Console.WriteLine("\nRe-rolling...");
                        keepRolling = true;
                        AdvantageDisadvantage = "Advantage";
                        reRoll = "";
                        dice_number1 = dice.Next(1, 20);
                        dice_number2 = dice.Next(1, 20);

                        Console.WriteLine("\nDice results: " + dice_number1 + " and " + dice_number2);

                        largerValue = System.Math.Max(dice_number1, dice_number2);

                        Console.WriteLine("\nThe larger value is: " + largerValue);

                        if (largerValue == 20) {
                        Console.WriteLine("\nCritical Hit!");
                        } 
                    
                        if (largerValue == 1) {
                        Console.WriteLine("\nCritical Miss!");
                        }

                        Console.WriteLine("\nWould you like to re-roll? (y/n)");
                        reRoll = Console.ReadLine();
                    }

                    if (reRoll == "n") {
                        Console.WriteLine("\nYou have chosen not to re-roll.");
                        reRoll = "";
                        AdvantageDisadvantage = "None";
                        howManyDice20 = 0;

                    }


                } else if (AdvantageDisadvantage == "Disadvantage") {

                    int dice_number1 = dice.Next(1, 20);
                    int dice_number2 = dice.Next(1, 20);
                    int smallerValue;

                    Console.WriteLine("\nDice results: " + dice_number1 + " and " + dice_number2);

                    smallerValue = System.Math.Min(dice_number1, dice_number2);            
                    
                    Console.WriteLine("\nThe smaller value is: " + smallerValue);

                    if (smallerValue == 20) {
                        Console.WriteLine("\nCritical Hit!");
                    } 
                    
                    if (smallerValue == 1) {
                        Console.WriteLine("\nCritical Miss!");
                    }

                    Console.WriteLine("\nWould you like to re-roll? (y/n)");
                    reRoll = Console.ReadLine();

                    while (reRoll == "y") {
                        Console.WriteLine("\nRe-rolling...");
                        keepRolling = true;
                        AdvantageDisadvantage = "Disadvantage";
                        reRoll = "";
                        dice_number1 = dice.Next(1, 20);
                        dice_number2 = dice.Next(1, 20);

                        Console.WriteLine("\nDice results: " + dice_number1 + " and " + dice_number2);

                        smallerValue = System.Math.Min(dice_number1, dice_number2);

                        Console.WriteLine("\nThe smaller value is: " + smallerValue);
         
                        if (smallerValue == 1) {
                        Console.WriteLine("\nCritical Miss!");
                        }

                        Console.WriteLine("\nWould you like to re-roll? (y/n)");
                        reRoll = Console.ReadLine();
                        }

                    if (reRoll == "n") {
                        Console.WriteLine("\nYou have chosen not to re-roll.");
                        reRoll = "";
                        AdvantageDisadvantage = "None";
                        howManyDice20 = 0;

                    }
                }

            } else if (howManyDice20 == 1) {
                int dice_number = dice.Next(1, 20);
                Console.WriteLine("\nDice results: " + dice_number);

                if (dice_number == 20) {
                    Console.WriteLine("\nCritical Hit!");
                }

                if (dice_number == 1) {
                    Console.WriteLine("\nCritical Miss!");
                }

                Console.WriteLine("\nWould you like to re-roll? (y/n)");
                reRoll = Console.ReadLine();

                while (reRoll == "y") {
                    Console.WriteLine("\nRe-rolling...");
                    keepRolling = true;
                    reRoll = "";
                    dice_number = dice.Next(1, 20);
                    Console.WriteLine("\nDice results: " + dice_number);

                    if (dice_number == 20) {
                    Console.WriteLine("\nCritical Hit!");
                    }

                    if (dice_number == 1) {
                    Console.WriteLine("\nCritical Miss!");
                    }

                    Console.WriteLine("\nWould you like to re-roll? (y/n)");
                    reRoll = Console.ReadLine();
                }

                if (reRoll == "n") {
                    Console.WriteLine("\nYou have chosen not to re-roll.");
                    reRoll = "";
                    AdvantageDisadvantage = "None";
                    howManyDice20 = 0;
                }
            }   
        }

        Console.WriteLine("\nWould you like to roll another die? (y/n)");
        String? rollAgain = Console.ReadLine();

        if (rollAgain == "y") {
            keepRolling = true;
            AdvantageDisadvantage = "None";

        } else if (rollAgain == "n") {
            keepRolling = false;
            AdvantageDisadvantage = "None";
        }
    }
}


while (keepRolling == false) {
    Console.WriteLine("\nThank you for using the DND Dice Roller!\nGood luck out there adventurer!\n");
    keepRolling = true;
}