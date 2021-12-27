using System.Linq;

int Integer;
string String;

string activeType;
string encounterType;

int damage;
int dialogueTime = 1500;

string[] normalA = { };
string[] normalD = { "rock", "steel" };
string[] normalN = { "ghost" };

string[] fightingA = { "normal", "rock", "steel", "ice", "dark" };
string[] fightingD = { "flying", "poison", "bug", "psychic", "fairy" };
string[] fightingN = { "ghost" };

string[] flyingA = { "fighting", "bug", "grass" };
string[] flyingD = { "rock", "steel", "electric" };
string[] flyingN = { };

string[] poisonA = { "grass", "fairy" };
string[] poisonD = { "poison", "ground", "rock", "ghost" };
string[] poisonN = { "steel" };

string[] groundA = { "poison", "rock", "steel", "fire", "electric" };
string[] groundD = { "bug", "grass" };
string[] groundN = { "flying" };

string[] rockA = { "flying", "bug", "fire", "ice"};
string[] rockD = { "fighting", "ground", "steel" };
string[] rockN = { };

string[] bugA = { "grass", "psychic", "dark" };
string[] bugD = { "fighting", "flying", "poison", "ghost", "steel", "fire", "fairy" };
string[] bugN = { };

string[] ghostA = { "ghost", "psychic" };
string[] ghostD = { "dark" };
string[] ghostN = { "normal" };

string[] steelA = { "rock", "ice", "fairy" };
string[] steelD = { "steel", "fire", "water", "electric" };
string[] steelN = { };

string[] fireA = { "bug", "steel", "grass", "ice" };
string[] fireD = { "rock", "fire", "water", "dragon" };
string[] fireN = { };

string[] waterA = { "ground", "rock", "fire" };
string[] waterD = { "water", "grass", "dragon" };
string[] waterN = { };

string[] grassA = { "ground", "rock", "water" };
string[] grassD = { "flying", "poison", "bug", "steel", "fire", "grass", "dragon" };
string[] grassN = { };

string[] electricA = { "flying", "water" };
string[] electricD = { "grass", "electric", "dragon" };
string[] electricN = { "ground" };

string[] psychicA = { "fighting", "poison", "ghost" };
string[] psychicD = { "steel", "psychic" };
string[] psychicN = { "dark" };

string[] iceA = { "flying", "ground", "grass", "dragon" };
string[] iceD = { "steel", "fire", "water" };
string[] iceN = { };

string[] dragonA = { "dragon" };
string[] dragonD = { "steel" };
string[] dragonN = { "fairy" };

string[] darkA = { "ghost", "psychic" };
string[] darkD = { "fighting", "dark", "fairy" };
string[] darkN = { };

string[] fairyA = { "fighting", "dragon", "dark" };
string[] fairyD = { "poison", "steel", "fire "};
string[] fairyN = { };


start:;
Console.Clear();
Console.WriteLine("Active[Type]");
String = Console.ReadLine();
activeType = String;
Console.Clear();
Console.WriteLine("Encounter[Type]");
String = Console.ReadLine();
encounterType = String;
Console.Clear();
if (activeType == "normal")
{
    if (normalA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (normalD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (normalN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "fighting")
{
    if (fightingA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (fightingD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (fightingN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "flying")
{
    if (flyingA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (flyingD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (flyingN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "poison")
{
    if (poisonA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (poisonD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (poisonN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "ground")
{
    if (groundA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (groundD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (groundN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "rock")
{
    if (rockA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (rockD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (rockN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "bug")
{
    if (bugA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (bugD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (bugN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "ghost")
{
    if (ghostA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (ghostD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (ghostN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "steel")
{
    if (steelA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (steelD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (steelN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "fire")
{
    if (fireA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (fireD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (fireN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "water")
{
    if (waterA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (waterD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (waterN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "grass")
{
    if (grassA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (grassD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (grassN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "electric")
{
    if (electricA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (electricD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (electricN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "psychic")
{
    if (psychicA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (psychicD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (psychicN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "ice")
{
    if (iceA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (iceD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (iceN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "dragon")
{
    if (dragonA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (dragonD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (dragonN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "dark")
{
    if (darkA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (darkD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (darkN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (activeType == "fairy")
{
    if (fairyA.Contains(encounterType))
    {
        Console.WriteLine(activeType + " > " + encounterType);
    }
    else if (fairyD.Contains(encounterType))
    {
        Console.WriteLine(activeType + " < " + encounterType);
    }
    else if (fairyN.Contains(encounterType))
    {
        Console.WriteLine(activeType + " = " + encounterType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else
{
    Console.WriteLine("Invalid type");
}

if (encounterType == "normal")
{
    if (normalA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (normalD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (normalN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "fighting")
{
    if (fightingA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (fightingD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (fightingN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "flying")
{
    if (flyingA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (flyingD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (flyingN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "poison")
{
    if (poisonA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (poisonD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (poisonN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "ground")
{
    if (groundA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (groundD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (groundN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "rock")
{
    if (rockA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (rockD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (rockN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "bug")
{
    if (bugA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (bugD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (bugN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "ghost")
{
    if (ghostA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (ghostD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (ghostN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "steel")
{
    if (steelA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (steelD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (steelN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "fire")
{
    if (fireA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (fireD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (fireN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "water")
{
    if (waterA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (waterD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (waterN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "grass")
{
    if (grassA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (grassD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (grassN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "electric")
{
    if (electricA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (electricD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (electricN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "psychic")
{
    if (psychicA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (psychicD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (psychicN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "ice")
{
    if (iceA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (iceD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (iceN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "dragon")
{
    if (dragonA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (dragonD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (dragonN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "dark")
{
    if (darkA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (darkD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (darkN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else if (encounterType == "fairy")
{
    if (fairyA.Contains(activeType))
    {
        Console.WriteLine(encounterType + " > " + activeType);
    }
    else if (fairyD.Contains(activeType))
    {
        Console.WriteLine(encounterType + " < " + activeType);
    }
    else if (fairyN.Contains(activeType))
    {
        Console.WriteLine(encounterType + " = " + activeType);
    }
    else
    {
        Console.WriteLine("Either invalid or normal damage");
    }
}
else
{
    Console.WriteLine("Invalid type");
}

Console.ReadKey();
goto start;