//Hero vs monster game
/*While I managed to get the code working, I did need a little
help with the victory and lost and message from the example code.
Overall great challenge!*/


Random attackRoll = new Random();
int heroHealth = 10;
int monsterHealth = 10;

do
{
    //Hero Attacks
    if (heroHealth > 0)
    {
        int heroDamage = 0;
        heroDamage = attackRoll.Next(1, 10);
        monsterHealth = monsterHealth - heroDamage;

        Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHealth} health.");
    }

    //Monster Attacks
    if (monsterHealth > 0)
    {
        int damage = 0;
        damage = attackRoll.Next(1, 10);
        heroHealth = heroHealth - damage;

        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
    }
    
} while ((heroHealth > 0) && (monsterHealth > 0));

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "The hero has fallen... Monster wins!");
