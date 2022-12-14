//Variables
using System.Net.Security;

int EnemyChance;
int Number;
string SpawnMessage;
string Choice;
int MonsterHP;
int yourHP = 1000;
int mondamage;
int blockchance;
int runchance;
int Critchance;
int ParryChance;
int monCritchance;
int Heals = 3;
int healthgain;
int Damage;
bool blocking = false;
int MonsterCHANCE;
bool debouce = false;
bool Spawned = false;
Random rnd = new Random();

//Functions
//Run
void run()
{
    Console.WriteLine("You attempt to run away");

    runchance = rnd.Next(1, 5);
    if (runchance != 1)
    {
        Console.WriteLine("You managed to escape");

        Thread.Sleep(2000);
        Environment.Exit(0);

    }
    else if (runchance == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("But the monster caught up to you..");

        Console.ForegroundColor = ConsoleColor.White;

    }
}
//Parry
void Parry()
{
   ParryChance = rnd.Next(1, 4);
   mondamage = rnd.Next(9, 35);

    if (ParryChance != 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.WriteLine("You Assume a defensive stance, your sword sheathed to your side, ready at a moments notice...");
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"The Monster Attacks!");
        Console.WriteLine("The monster prepares its attack, drawing back its hideous fist.");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(1000);

        Console.WriteLine("It Launches it foward.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Thread.Sleep(1000);

        mondamage = mondamage * 2;
        Console.WriteLine($"The monster deals {mondamage} damage, however you draw you sword within an instant reppeling the attack into the monsters own face!");
        Console.WriteLine($"The monster took {mondamage} damage");
        MonsterHP -= mondamage;

        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"The monster has {MonsterHP} health left");
        Console.WriteLine($"You have {yourHP} health left");

    }
    else if (ParryChance == 1)
    {
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(1500);

        Console.WriteLine($"The Monster Attacks!");
        Console.WriteLine("The monster prepares its attack, drawing back its hideous fist.");
        Console.WriteLine($"The monster strikes! dealing {mondamage} damage!");
        Thread.Sleep(1500);

        Console.ForegroundColor = ConsoleColor.White;

        yourHP -= mondamage;
        Console.WriteLine($"You have {yourHP} health left");


    }

    if (MonsterHP > 0 && yourHP > 0)
    {
        if (yourHP <= 0)
        {
            Console.WriteLine("You Have died!");
            Thread.Sleep(2000);

        }
        else if (yourHP > 0)
        {
            debouce = false;

        }

    }
}
//Heal
void Heal()
{
    Critchance = rnd.Next(0, 10);
    monCritchance = rnd.Next(0, 2);

    blockchance = rnd.Next(0, 6);
    Damage = rnd.Next(12, 50);
    mondamage = rnd.Next(9, 35);

    if (Heals > 0)
    {
        healthgain = rnd.Next(10, 15);
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("You swiftly grab the red potion from you side and down it..");
        Heals = Heals - 1;
        Thread.Sleep(3000);
        Console.WriteLine($"You have {Heals} Potions left!");

        Console.WriteLine($"You Gain {healthgain} Health!");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.White;

        yourHP = yourHP + healthgain;
        Console.WriteLine($"You have {yourHP} Health");
    }
    else if (Heals <= 0)
    {
        Console.WriteLine("You put your hand to your side to grab a potion but..");

        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(2000);
        Console.WriteLine("Theres nothing there");

        Thread.Sleep(2000);

        Console.ForegroundColor = ConsoleColor.White;



    }

    if (MonsterHP > 0 && yourHP > 0)
    {
        Thread.Sleep(2000);
        Console.WriteLine($"The Monster has  {MonsterHP} Health");

        if (blockchance != 1 && monCritchance != 1)
        {
            Console.WriteLine("The Monster Winds back its enlarged fist and strikes!");
            Thread.Sleep(2000);

            Console.WriteLine($"The monster deals {mondamage} damage, However you blocked it! ");
            yourHP = yourHP;
            Console.WriteLine($"you have {yourHP} Health Left. You remain intact!");
            Thread.Sleep(2000);
        }
        else if (blockchance != 1 && monCritchance == 1)
        {
            Console.WriteLine("The Monster Winds back its enlarged fist ");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(2000);
            Console.WriteLine("It glows red with energy");
            Thread.Sleep(2000);
            mondamage = mondamage * 2;
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(2000);

            Console.WriteLine($"The monster deals {mondamage} damage,");
            yourHP = yourHP - mondamage * 4 / 3;
            Console.WriteLine($"you have {yourHP} Health Left.");

        }


        if (yourHP <= 0)
        {
            Console.WriteLine("You Have died!");
            Thread.Sleep(2000);

        }
        else if (yourHP > 0)
        {
            debouce = false;

        }


    }
}
//Block
void Block()
{
    Critchance = rnd.Next(0, 10);
    monCritchance = rnd.Next(0, 10);

    blockchance = rnd.Next(0, 6);
    Damage = rnd.Next(12, 50);
    mondamage = rnd.Next(9, 35);
    Thread.Sleep(2000);


    if (blockchance != 1 && monCritchance != 1)
    {
        Console.WriteLine("The Monster Winds back its enlarged fist and strikes!");
        Thread.Sleep(2000);

        Console.WriteLine($"The monster deals {mondamage} damage, However you blocked it! ");
        yourHP = yourHP;
        Console.WriteLine($"you have {yourHP} Health Left. You remain intact!");
        Thread.Sleep(2000);
    }
    else if (blockchance != 1 && monCritchance == 1)
    {
        Console.WriteLine("The Monster Winds back its enlarged fist ");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(1000);
        Console.WriteLine("It glows red with energy");
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.White;

        Thread.Sleep(2000);

        Console.WriteLine($"The monster deals {mondamage} damage, You atempted to block but your guard was broken!");
        yourHP = yourHP - mondamage * 4 / 3;
        Console.WriteLine($"you have {yourHP} Health Left.");

    }


    if (yourHP <= 0)
    {
        Console.WriteLine("You Have died!");
        Thread.Sleep(2000);

    }
    else if (yourHP > 0)
    {
        debouce = false;

    }

}
//Attacl
void Attack()
{
    Critchance = rnd.Next(0, 10);
    monCritchance = rnd.Next(0, 10);
    Damage = rnd.Next(12, 50);
    mondamage = rnd.Next(9, 35);
    Thread.Sleep(2000);
    if (Critchance == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(1000);
        Console.WriteLine("You charge up  strong attack!");
        Thread.Sleep(1000);

        Thread.Sleep(1000);

        Damage = Damage * 2;
        Console.WriteLine($"Your Attack did {Damage} Damage, Critical!");

        MonsterHP = MonsterHP - Damage;
    }
    else if (Critchance != 1)
    {

        Console.WriteLine($"Your Attack did {Damage} Damage");
        MonsterHP = MonsterHP - Damage;

    }

    if (MonsterHP <= 0)
    {
        Thread.Sleep(2000);

        Spawned = false;
        Console.WriteLine("The Monster has died");
        Thread.Sleep(2000);

    }
    else if (MonsterHP > 0 && yourHP > 0)
    {
        Thread.Sleep(2000);
        Console.WriteLine($"The Monster has  {MonsterHP} Health");


        Console.WriteLine("The Monster Winds back its enlarged fist and strikes!");
        Thread.Sleep(2000);

        if (monCritchance == 1)
        {
            mondamage = mondamage * 2;
            yourHP = yourHP - mondamage;
            Console.WriteLine($"you have {yourHP} Health Left ");
            Thread.Sleep(2000);
        }

        else if (monCritchance != 1)
        {
            Console.WriteLine($"The monster deals {mondamage} damage ");
            yourHP = yourHP - mondamage;
            Console.WriteLine($"you have {yourHP} Health Left ");
            Thread.Sleep(2000);
        }


        if (yourHP <= 0)
        {
            Console.WriteLine("You Have died!");
            Thread.Sleep(2000);

        }
        else if (yourHP > 0)
        {
            debouce = false;

        }


    }
}
//actionmanager
void Action()
{
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    Console.WriteLine("What would you like to do [Attack] [Parry] [Block] [Heal] [Run]");
    string answer = Console.ReadLine();
    if (answer == "Attack" ^ answer == "attack")
    {
        Attack();
    }
    else if (answer == "Parry" ^ answer == "parry")
    {
        Parry();
    }
    else if (answer == "Heal" ^ answer == "heal")
    {
        Heal();
    }
    else if (answer == "Block" ^ answer == "block")
    {
        Block();
    }
    else if (answer == "Run" ^ answer == "run")
    {

    }
    
}

//GameStart
void GameStart()
{
    if (Spawned == true)
    {
        while (Spawned = true && debouce == false)
        {
            debouce = true;
            Console.WriteLine($"The Monster has  {MonsterHP} Health");
            Thread.Sleep(2000);
            Action();
        }
    }
}



//Monster Spawn
void MonsterSpawn()
{
    Console.WriteLine("You rustle through the Bushes");

    MonsterCHANCE = rnd.Next(1, 2);
    if (MonsterCHANCE == 1)
    {
        Console.WriteLine("As you walk through the bushes a creature appears!");

        Spawned = true;
        MonsterHP = rnd.Next(100, 200);
        GameStart();
        
    }
    else if (MonsterCHANCE != 1)
    {
        Spawned = false;
        Console.WriteLine("Nothing Happens");

    }
}



MonsterSpawn();
