﻿int EnemyChance;
int Number;
string SpawnMessage;
string Choice;
int MonsterHP;
int yourHP = 100;
int mondamage;
int blockchance;
int Critchance;
int monCritchance;
int Heals = 3;
int healthgain;
int Damage;
Boolean blocking = false;
int MonsterCHANCE;
Boolean debouce = false;

SpawnMessage = "A monster Has spawned";
Boolean Spawned = false;
Random rnd = new Random();

MonsterHP = rnd.Next(100, 200);
MonsterCHANCE = rnd.Next(1, 1);
if (MonsterCHANCE == 1)
{
    Spawned = true;
    Console.WriteLine(SpawnMessage);
    Thread.Sleep(2000);
    Console.WriteLine(@"
        .--'''''''''--.
     .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
     '-._| | | | | | |_.-'
         | '-' | '-' |
          \___/ \___/
       _.-'  /   \  `-._
     .' _.--|     |--._ '.
     ' _...-|     |-..._ '
            |     |
            '.___.'
              | |
             _| |_
            /\( )/\
           /  ` '  \
          | |     | |
          '-'     '-'
          | |     | |
          | |     | |
          | |-----| |
       .`/  |     | |/`.
       |    |     |    |
       '._.'| .-. |'._.'
             \ | /
             | | |
             | | |
             | | |
            /| | |\
          .'_| | |_`.
LJP       `. | | | .'
       .    /  |  \    .
      /o`.-'  / \  `-.`o\
     /o  o\ .'   `. /o  o\
     `.___.'       `.___.'
");
}
else if (MonsterCHANCE != 1)
{
    Spawned = false;
}
if (Spawned == true)
{
    while (Spawned == true && debouce == false)
    {
        debouce = true;
        Console.WriteLine($"The Monster has  {MonsterHP} Health");
        Thread.Sleep(2000);

        Console.WriteLine("What would you like to do? [Attack] [Block] [Heal]");
        Thread.Sleep(2000);

        string answer = Console.ReadLine();

        if (answer == "Attack" ^ answer == "attack")
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
        else if (answer == "Block" ^ answer == "block")
        {
            Critchance = rnd.Next(0, 10);
            monCritchance = rnd.Next(0, 10);

            blockchance = rnd.Next(0, 6);
            Damage = rnd.Next(12, 50);
            mondamage = rnd.Next(9, 35);
            Thread.Sleep(2000);


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
        }
        else if (answer == "Heal" ^ answer == "heal")
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
        }

    }
}