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

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите ваш возраст: ");
int age = ReadInt("Пожалуйста, введите корректный возраст: ", 0, 200);


Console.WriteLine("\nВыберите путь вашего героя:");
Console.ForegroundColor = ConsoleColor.Red;    Console.WriteLine("  1. [ВОИН]    - Сокрушительная мощь");
Console.ForegroundColor = ConsoleColor.Blue;   Console.WriteLine("  2. [МАГ]     - Тайные знания");
Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine("  3. [ЛУЧНИК]  - Смертоносная точность");
Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("  4. [ВОР]     - Тени и кинжалы");
Console.ResetColor();

int choice = ReadInt("Введите номер (1-4): ", 1, 4);

string classi = "";
string weapontype = "";
ConsoleColor classColor = ConsoleColor.White;

switch (choice)
{
    case 1: classi = "Воин"; classColor = ConsoleColor.Red; break;
    case 2: classi = "Маг"; classColor = ConsoleColor.Blue; break;
    case 3: classi = "Лучник"; classColor = ConsoleColor.Green; break;
    case 4: classi = "Вор"; classColor = ConsoleColor.Yellow; break;
}


Console.Clear();
Console.ForegroundColor = classColor;
Console.WriteLine($">>> ВЫ ВСТУПИЛИ НА ПУТЬ: {classi.ToUpper()} <<<");
Console.ResetColor();

Console.WriteLine("\nДоступное снаряжение:");

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.ResetColor();
weapontype = "Меч и Щит"; 


Console.WriteLine("\nВыберите уровень испытания:");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("1. Easy | 2. Medium | 3. Hard");
int leveldiff = ReadInt("Сложность: ", 1, 3);
Difficulty difficulty = (Difficulty)leveldiff;
Console.ResetColor();

int stata = 20;
Console.Clear();
Console.WriteLine("--- АЛТАРЬ ХАРАКТЕРИСТИК ---");
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
double Damage = (strength * 1.5) + (status == "" ? 0 : 10);

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("┌───────────────────────────────────────┐");
Console.Write("│ "); Console.ForegroundColor = ConsoleColor.White; Console.Write("КАРТОЧКА ГЕРОЯ:"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("                      │");
Console.WriteLine("├───────────────────────────────────────┤");

Console.Write("│ "); Console.ForegroundColor = classColor; Console.Write($"{name} {surname}".PadRight(20));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine($"Класс: {classi}".PadRight(15) + " │");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write($"Возраст: {age}".PadRight(20));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine($"Сложность: {difficulty}".PadRight(15) + " │");

Console.WriteLine("├───────────────────────────────────────┤");


Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Red; Console.Write($"HP:   {HP.ToString().PadRight(4)} ");
Console.Write(new string('■', HP / 10).PadRight(20, '·'));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" │");


Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"MANA: {MP.ToString().PadRight(4)} ");
Console.Write(new string('■', MP / 10).PadRight(20, '·'));
Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" │");

Console.WriteLine("├───────────────────────────────────────┤");


Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
Console.ForegroundColor = ConsoleColor.White; Console.Write("ОРУЖИЕ: ");
if (status != "") { Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($"{status} "); }
Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(weapontype);
Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("".PadLeft(31 - (status.Length + weapontype.Length + (status != "" ? 1 : 0))) + "│");

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

public enum Difficulty : byte { Easy = 1, Medium, Hard }