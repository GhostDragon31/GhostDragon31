/*D&D Dice Roller*/
// A basic dice roller for Dungeons and Dragons. Rolls a d4, d6, d8, d10, d100, d12, and d20. (Entry level C# practice project)

//Dice perameters
Random dice = new Random();
int rollD4 = dice.Next(1, 4);
int rollD6 = dice.Next(1, 6);
int rollD8 = dice.Next(1, 8);
int rollD10 = dice.Next(0, 9);
int rollD100 = dice.Next(0, 9);
int rollD12 = dice.Next(1, 12);
int rollD20 = dice.Next(1, 20);

//Print results
Console.WriteLine($"\nFirst Roll (d4): {rollD4}"); 
Console.WriteLine($"Second Roll (d6): {rollD6}");
Console.WriteLine($"Third Roll (d8): {rollD8}");
Console.WriteLine($"Fourth Roll (d10): {rollD10}");
Console.WriteLine($"Fifth Roll (d12): {rollD12}\n");

Console.WriteLine($"Sixth Roll (d100): {rollD100}");

//D100 result explanation
if (rollD100 == 0) {
    Console.WriteLine("Roll is: 100");
} else if (rollD100 == 1) {
    Console.WriteLine($"Roll is: 10");
}
 else if (rollD100 == 2) {
    Console.WriteLine($"Roll is: 20");
}
 else if (rollD100 == 3) {
    Console.WriteLine($"Roll is: 30");
}
 else if (rollD100 == 4) {
    Console.WriteLine($"Roll is: 40");
}
 else if (rollD100 == 5) {
    Console.WriteLine($"Roll is: 50");
}
 else if (rollD100 == 6) {
    Console.WriteLine($"Roll is: 60");
}
else if (rollD100 == 7) {
    Console.WriteLine($"Roll is: 70");
}
else if (rollD100 == 8) {
    Console.WriteLine($"Roll is: 80");
}
else if (rollD100 == 9) {
    Console.WriteLine($"Roll is: 90");
}

Console.WriteLine($"\nSeventh Roll (d20): {rollD20}");

//Crit or Miss
if (rollD20 == 20) {
    Console.WriteLine("Critical Hit!\n");
} else if (rollD20 == 1) {
    Console.WriteLine("Critical Miss!\n");
} else {
    Console.WriteLine("Normal Roll\n");
}
