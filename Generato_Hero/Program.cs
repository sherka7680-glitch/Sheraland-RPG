using System;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=========================================");
Console.WriteLine("        ДОБРО ПОЖАЛОВАТЬ В ИГРУ          ");
Console.WriteLine("            SHERALAND RPG                ");
Console.WriteLine("=========================================");
Console.ResetColor();

string name = ReadStr("Введите ваше имя: ");
string surname = ReadStr("Введите вашу фамилию: ");
Console.Write("Введите ваш возраст: ");
int age = ReadInt("Пожалуйста, введите корректный возраст: ", 18, 55);


Console.WriteLine("\nВыберите путь вашего героя:");
Console.ForegroundColor = ConsoleColor.Red;    Console.WriteLine("  1. [ВОИН]    - Сокрушительная мощь");
Console.ForegroundColor = ConsoleColor.Blue;   Console.WriteLine("  2. [МАГ]     - Тайные знания");
Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine("  3. [ЛУЧН(ЛУЧНИК)]  - Смертоносная точность");
Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("  4. [ВОР]     - Тени и кинжалы");
Console.ResetColor();

int choice = ReadInt("Введите номер (1-4): ", 1, 4);

string classi = "";
string weapontype = "";
ConsoleColor classColor = ConsoleColor.White;

switch (choice)
{
    case 1: classi = "Воин"; classColor = ConsoleColor.Red; break;
    case 2: classi = "Маг "; classColor = ConsoleColor.Blue; break;
    case 3: classi = "Лучник"; classColor = ConsoleColor.Green; break;
    case 4: classi = "Вор "; classColor = ConsoleColor.Magenta; break;
}


Console.Clear();
Console.ForegroundColor = classColor;
Console.WriteLine($">>> ВЫ ВСТУПИЛИ НА ПУТЬ: {classi.ToUpper()} <<<");
Console.ResetColor();


Console.WriteLine("\nВыберите уровень испытания:");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("1. Easy | 2. Medium(Medi) | 3. Hard");
int leveldiff = ReadInt("Сложность: ", 1, 3);
Difficulty difficulty = (Difficulty)leveldiff;
Console.ResetColor();
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("--- ВЫБОР ОРУЖИЯ ---");
switch (choice)

{

    case 1:

        Console.ResetColor();
        Console.WriteLine("Доступное оружие для Воина");

        classi="Воин";


        Console.WriteLine("Выберите оружие для Воина: ");

        Console.WriteLine("1. Меч и Щит");

        Console.WriteLine("2. Топор");

        int weaponChoice = ReadInt("Введите номер оружия (1-2): ", 1, 2);

        weapontype = weaponChoice switch

        {

            1 => "Меч и Щит",

            2 => "Топор",

            _ => "Такого оружия нет."

        };
Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Вы выбрали оружие: {weapontype}");

        break;

        case 2:

      Console.ResetColor();  

       Console.WriteLine("Доступное оружие для Мага");

        classi="Маг ";

       

        Console.WriteLine("Выберите оружие для Мага: ");
     

        Console.WriteLine("1. Огненный посох");
       
        Console.WriteLine("2. Ледяной посох");
Console.ResetColor();
        int skillChoice = ReadInt("Введите номер оружия (1-2): ", 1, 2);

        weapontype = skillChoice switch

        {

            1 => "Огненный посох",

            2 => "Ледяной посох",

            _ => "Такого оружия нет."

        };
Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Вы выбрали оружие: {weapontype}");
Console.ResetColor();
        break;

    case 3:

        Console.ResetColor();
         Console.WriteLine("Доступное оружие для Лучника");

       

        classi="Лучн";

      

        Console.WriteLine("Выберите оружие для Лучника: ");

        Console.WriteLine("1. Лук и Обычные стрелы");

        Console.WriteLine("2. Арбалет");
Console.ResetColor();   
        int arrowChoice = ReadInt("Введите номер типа стрел (1-2): ", 1, 2);

        weapontype = arrowChoice switch

        {

            1 => "Обычные стрелы",

            2 => "Ядовитые стрелы",

            _ => "Такого типа стрел нет."

        };
Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Вы выбрали тип стрел: {weapontype}");

        break;

    case 4:

        Console.ResetColor();
       
 Console.WriteLine("Доступное оружие для Мага");
        

        classi="Вор ";

      

        Console.WriteLine("Выберите оружие для Вора: ");

        Console.WriteLine("1. Кинжал");

        Console.WriteLine("2. Скрытное оружие");

        int rogueSkillChoice = ReadInt("Введите номер оружия (1-2): ", 1, 2);

        weapontype= rogueSkillChoice switch

        {

            1 => "Кинжал",

            2 => "Скрытное оружие",

            _ => "Такого оружия нет."

        };
Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Вы выбрали оружие: {weapontype}");

        break;

    default:

            Console.WriteLine("Такого класса нет.");

            break;

}
int stata = 20;
Console.Clear();
Console.ForegroundColor=ConsoleColor.Magenta;
Console.WriteLine("--- АЛТАРЬ ХАРАКТЕРИСТИК ---");
Console.ResetColor();
Console.WriteLine($"Доступно магической энергии: {stata} единиц.");

Console.ForegroundColor = ConsoleColor.Red;
int strength = ReadInt("Очков в СИЛУ: ", 0, stata);
Console.ForegroundColor = ConsoleColor.Blue;
int intiligence = ReadInt("Очков в ИНТЕЛЛЕКТ: ", 0, stata - strength);
Console.ResetColor();

int HP = 50 + (strength * 10);
int MP = intiligence * 15;
Random random = new Random();
int luck = random.Next(0, 101);
string status = luck > 90 ? "ЛЕГЕНДАРНЫЙ" : "";
if (status == "ЛЕГЕНДАРНЫЙ") { HP += 20; MP += 20; }
double Damage = (strength * 1.5) + (status == "" ? 0 : 10);

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("┌───────────────────────────────────────┐");
Console.Write("│ "); Console.ForegroundColor = ConsoleColor.White; Console.Write("КАРТОЧКА ГЕРОЯ:"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("                       │");
Console.WriteLine("├───────────────────────────────────────┤");

Console.Write("│ "); Console.ForegroundColor = classColor; Console.Write($"{name} {surname}".PadRight(20));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Gray; Console.Write($"Класс: ");
Console.ForegroundColor = classColor;
Console.Write($"{classi}");
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("".PadRight(4) + " │");
ConsoleColor difcollor= difficulty switch
{
    Difficulty.Easy => ConsoleColor.Green,
    Difficulty.Medi => ConsoleColor.Yellow,
    Difficulty.Hard => ConsoleColor.Red,
    _ => ConsoleColor.Gray
};
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write($"Возраст: {age}".PadRight(20));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Gray; Console.Write($"Сложность: ");
Console.ForegroundColor = difcollor;
Console.Write($"{difficulty}");
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("".PadRight(0) + " │"); 

Console.WriteLine("├───────────────────────────────────────┤");


Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Red; Console.Write($"HP:   {HP.ToString().PadRight(4)} ");
Console.Write(new string('■', (HP / 10)>20 ? 20 : HP / 10).PadRight(20, '·'));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");


Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"MANA: {MP.ToString().PadRight(4)} ");
Console.Write(new string('■', (MP / 10)>20 ? 20 : MP / 10).PadRight(20, '·'));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");

Console.WriteLine("├───────────────────────────────────────┤");


Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.White; Console.Write("ОРУЖИЕ: ");
if (status != "") { Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($"{status} "); }else { Console.ForegroundColor = classColor;}
Console.Write(weapontype);
Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("".PadLeft(31 - (status.Length + weapontype.Length + (status != "" ? 2 : 1))) + "│");

Console.WriteLine("└───────────────────────────────────────┘");
Console.ResetColor();

static int ReadInt(string prompt, int min, int max)
{
    int result;
    while (!int.TryParse(Console.ReadLine(), out result) || result < min || result > max)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("! " + prompt);
        Console.ResetColor();
    }
    return result;
}
static string ReadStr(string prompt)
{
    
    Console.Write(prompt);
    string str = Console.ReadLine();
    while (string.IsNullOrEmpty(str)||string.IsNullOrWhiteSpace(str))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("! " + prompt);
        Console.ResetColor();
        str = Console.ReadLine();
    }
    return str;
}
public enum Difficulty : byte { Easy = 1, Medi, Hard }