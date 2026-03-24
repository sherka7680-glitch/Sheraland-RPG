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

string name = ReadStr("\n[?] Введите ваше имя: ");
string surname = ReadStr("[?] Введите вашу фамилию: ");
Console.Write("[?] Введите ваш возраст: ");
int age = ReadInt("[!] Введите корректный возраст (18-150): ", 18, 55);


Console.WriteLine("\nВыберите путь вашего героя:\n");
Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("  1. [ВОИН]    - Сокрушительная мощь");
Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("  2. [МАГ]     - Тайные знания");
Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("  3. [ЛУЧН(ЛУЧНИК)]  - Смертоносная точность");
Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("  4. [ВОР]     - Тени и кинжалы");
Console.ResetColor();
Console.Write("\n[?] Выберите класс вашего героя: ");
int choice = ReadInt("[!] Введите номер (1-4): ", 1, 4);

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

        classi = "Воин";


        Console.WriteLine("Выберите оружие для Воина: ");

        Console.WriteLine("1. Меч и Щит");

        Console.WriteLine("2. Топор");
        Console.Write("[?] Введите номер оружия (1-2): ");
        int weaponChoice = ReadInt("[!] Введите номер оружия (1-2): ", 1, 2);

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
        classi = "Маг ";
        Console.WriteLine("Выберите оружие для Мага: ");
        Console.WriteLine("1. Огненный посох");
        Console.WriteLine("2. Ледяной посох");
        Console.ResetColor();
        Console.Write("[?] Введите номер оружия (1-2): ");
        int skillChoice = ReadInt("[!] Введите номер оружия (1-2): ", 1, 2);
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



        classi = "Лучн";



        Console.WriteLine("Выберите оружие для Лучника: ");

        Console.WriteLine("1. Лук");

        Console.WriteLine("2. Арбалет");
        Console.ResetColor();
        Console.Write("[?] Введите номер оружия (1-2): ");
        int arrowChoice = ReadInt("[!] Введите номер оружия (1-2): ", 1, 2);

        weapontype = arrowChoice switch

        {

            1 => "Лук",

            2 => "Арбалет",

            _ => "Такого типа стрел нет."

        };
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Вы выбрали оружие: {weapontype}");

        break;

    case 4:

        Console.ResetColor();

        Console.WriteLine("Доступное оружие для Вора");


        classi = "Вор ";



        Console.WriteLine("Выберите оружие для Вора: ");

        Console.WriteLine("1. Кинжал");

        Console.WriteLine("2. Скрытное оружие");
        Console.ResetColor();
        Console.Write("[?] Введите номер оружия (1-2): ");

        int rogueSkillChoice = ReadInt("[!] Введите номер оружия (1-2): ", 1, 2);

        weapontype = rogueSkillChoice switch

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
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("--- АЛТАРЬ ХАРАКТЕРИСТИК ---");
Console.ResetColor();
Console.WriteLine($"Доступно магической энергии: {stata} единиц.");
Console.Write("Очков в СИЛУ: ");
Console.ForegroundColor = ConsoleColor.Red;

int strength = ReadInt("Очков в СИЛУ: ", 0, stata);
Console.ResetColor();
Console.Write("Очков в ИНТЕЛЛЕКТ: ");
Console.ForegroundColor = ConsoleColor.Blue;
int intiligence = ReadInt("Очков в ИНТЕЛЛЕКТ: ", 0, stata - strength);
Console.ResetColor();

int HP = 50 + (strength * 10);
int MaxHp=HP;
int MP = intiligence * 15;
int MaxMp=MP;
Random random = new Random();
int luck = random.Next(0, 101);
string status = luck > 90 ? "ЛЕГЕНДАРНЫЙ" : "";
if (status == "ЛЕГЕНДАРНЫЙ") { HP += 20;MaxHp=HP; MP += 20;MaxMp=MP; }
double Damage = (strength * 1.5) + (status == "" ? 0 : 10);
List<string> enemies = ["Слизь", "Гоблин", "Орк", "Тролль", "Дракон"];
List<string> loots = ["Зелье здоровья", "Меч", "Щит", "Лук", "Арбалет"];
List<string> inventory = new List<string>();
List<int> itemPrices = new List<int>();
int energy = 10;
int money = 0;
int strenght = strength;
int maxcapacity = 5 + (strenght / 2);
Random rand = new Random();
StatusShow(classColor, name, surname, classi, difficulty, age, HP, MP,MaxHp,MaxMp, weapontype, status, strenght, energy, money);
Console.WriteLine("\nВаш герой готов к приключениям! Удачи в ваших подвигах!");
Console.ReadKey();
while (true)
{
    Console.Clear();
    maxcapacity = 5 + (strenght / 2);
    Console.WriteLine("1. Статус | 2. Выход. | 3. Работать | 4. Отдохнуть | 5. Тренироваться | 6. В поход | 7. Идти к торговцу");
    Console.Write("Ваш выбор: ");
    int Menu = ReadInt("Введите  корректные данные(1,2,3,4,5,6,7): ", 1, 7);
    string statusMessage = "";
    bool IsExit = false;
    switch (Menu)
    {
        case 1:
            StatusShow(classColor, name, surname, classi, difficulty, age, HP, MP,MaxHp,MaxMp, weapontype, status, strenght, energy, money, inventory);
            Console.WriteLine("\nВаш герой готов к приключениям! Удачи в ваших подвигах!");
            Console.ReadKey();
            break;
        case 2:
            IsExit = true;
            break;
        case 3:
            if (energy == 0)
            {
                statusMessage = "Вы слишком устали";
                Console.WriteLine(statusMessage);
                Console.ReadKey();
                break;
            }
            energy -= 1;
            int works = rand.Next(1, 11);
            money += works;
            Console.WriteLine($"Заработано {works} монет. Осталось энергии: {energy}");
            Console.ReadKey();
            break;
        case 4:
            if (money < 5)
            {
                Console.WriteLine("Недостаточно денег для отдыха.");
                Console.ReadKey();
                break;
            }
            money -= 5;
            energy = 10;
            Console.WriteLine("Вы отдохнули у вас полный запас энергии.");
            Console.ReadKey();
            break;
        case 5:
            Console.WriteLine("Нужно нажать любую клавишу 5 раз, чтобы закончить тренировку.");
            int a = 0;
            while (true)
            {
                if (a > 4)
                {
                    break;
                }
                Console.ReadKey();
                a++;
            }
            strenght++;
            energy -= 1;
            Console.WriteLine("Твоя сила увеличилась на 1. Текущая сила: " + strenght);
            Console.ReadKey(); break;
        case 6:
            if (energy < 2)
            {
                Console.WriteLine("У вас недостаточно энергии для похода.");
                Console.ReadKey();
                break;
            }

            energy -= 2;
            Console.WriteLine("Вы отправились в поход.");
            int gacha = rand.Next(1, 4);
            switch (gacha)
            {
                case 1:
                    int encounter = rand.Next(1, enemies.Count);
                    Console.WriteLine($"Вы встретили {enemies[encounter]}!");
                    Console.WriteLine("Вы сражаетесь с врагом...");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Удар по {enemies[encounter]}! ({i + 1}/3)");
                        Console.ReadKey();
                    }
                    int outcome = rand.Next(1, 2);
                    Console.WriteLine(outcome == 1 ? "Вы победили!" : "Вы проиграли!");
                    if (outcome == 1)
                    {
                        if (!(inventory.Count > maxcapacity))
                        {

                            int loot = rand.Next(0, loots.Count);
                            itemPrices.Add(rand.Next(10, 50));
                            inventory.Add(loots[loot]);


                            Console.WriteLine($"Вы получили {loots[loot]} в качестве добычи!");
                        }
                        else
                        {
                            Console.WriteLine("Слишком тяжело, вы оставили трофей на земле");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Вы ранены");
                        HP-=20;
                           if (HP <= 0)
                    {
                        Console.WriteLine("Вы погибли в засаде...");
                        Console.WriteLine("Игра окончена.");
                        IsExit = true;
                        break;
                    }
                        if (money > 0)
                        {
                            Console.WriteLine("Вы потеряли 5 монет.");
                            money -= 5;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет монет, чтобы потерять.");
                        }


                        Console.ReadKey();
                        break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Вы нашли сундук с сокровищами!");
                    if (!(inventory.Count > maxcapacity))
                    {
                        int loot = rand.Next(0, loots.Count);
                        itemPrices.Add(rand.Next(10, 50));
                        inventory.Add(loots[loot]);
                        Console.WriteLine($"Вы получили {loots[loot]} в качестве добычи!");
                    }
                    else
                    {
                        Console.WriteLine("Слишком тяжело, вы оставили трофей на земле");
                    }
                    break;
                    case 3:
                    Console.WriteLine("ЗАСАДА! Вас атаковали бандиты!");
                    HP -= 20;
                    Console.WriteLine("Вы потеряли 20 HP.");
                    if (HP <= 0)
                    {
                        Console.WriteLine("Вы погибли в засаде...");
                        Console.WriteLine("Игра окончена.");
                        IsExit = true;
                    }
                    break;
            }
            Console.ReadKey();
            break;
        case 7:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Торговец ---");
            Console.ResetColor();
            Console.WriteLine("1. Продать все трофеи (5 монет за каждый) | 2. Продать последний поднятый предмет | 3.Выйти из магазина");
            Console.Write("Ваш выбор: ");
            int shopchoice = ReadInt("Введите  корректные данные(1,2,3): ", 1, 3);
            switch (shopchoice)
            {
                case 1:
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("У вас нет трофеев для продажи.");
                        Console.ReadKey();
                        break;
                    }
                    int balan = 0;
                    for (int i = 0; i < inventory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {inventory[i]} - {itemPrices[i]} монет");
                        money += itemPrices[i];
                        balan += itemPrices[i];
                    }
                    inventory.Clear();
                    Console.WriteLine($"Вы продали все трофеи за {balan} монет.");
                    Console.ReadKey(); break;
                case 2:
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("У вас нет трофеев для продажи.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine($"Вы продали {inventory[inventory.Count - 1]} за {itemPrices[itemPrices.Count - 1]} монет.");
                    money += itemPrices[itemPrices.Count - 1];
                    inventory.RemoveAt(inventory.Count - 1);
                    itemPrices.RemoveAt(itemPrices.Count - 1);
                    break;
                case 3: Console.WriteLine("Goodbye!"); break;
            }
            Console.WriteLine("Спасибо что зашли!"); Console.ReadKey(); break;
    }

    if (IsExit)
    {
        break;
    }

}
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
    while (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("! " + prompt);
        Console.ResetColor();
        str = Console.ReadLine();
    }
    return str;
}
static void StatusShow(ConsoleColor classColor, string name, string surname, string classi, Difficulty difficulty, int age, int HP, int MP,int MaxHp , int MaxMp, string weapontype, string status, int strenght = 1, int energy = 10, int money = 0, List<string> inventory = null)
{

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
    ConsoleColor difcollor = difficulty switch
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
    Console.ForegroundColor = ConsoleColor.Red; 
    int mat = MaxHp / 10 > 20 ? 20 : MaxHp / 10;
    int mathp=HP / 10 > 20 ? 20 : HP / 10;
    string hpbar=HP<100?$"{HP} ":$"{HP}";
    string maxhp=MaxHp<100?$"{MaxHp} ":$"{MaxHp}";
    string hpText = $"HP:   {hpbar}/{MaxHp} ";
Console.Write(hpText);
    Console.Write(new string('■', mathp).PadRight(mat, '·').PadRight(17, ' '));
    Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");

    int matmp = MaxMp / 10 > 20 ? 20 : MaxMp / 10;
    int matmpc=MP / 10 > 20 ? 20 : MP / 10;
    string mpbar=MP<100?$"{MP} ":$"{MP}";
    string maxmp=MaxHp<100?$"{MaxMp} ":$"{MaxMp}";
    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
    Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"MANA: {mpbar}/{maxmp} ");
    Console.Write(new string('■', matmpc).PadRight(matmp, '·').PadRight(17, ' '));
    Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");
    Console.WriteLine("├───────────────────────────────────────┤");
    Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray; //Console.Write($" Осталось энергии: {energy}.\n Осталось {money} монет.");
    Console.Write($" Сила: {strenght}".PadRight(31, ' ') + ""); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");
    Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write($" Осталось энергии: {energy}".PadRight(31, ' ') + ""); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");
    Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write($" Осталось {money} монет".PadRight(31, ' ') + ""); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");
    Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write($" Инвентарь:".PadRight(31, ' ') + ""); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");
    if (!((inventory?.Count ?? 0) == 0))
    {
        for (int i = 0; inventory != null && i < inventory.Count; i++)
        {
            Console.Write("│ "); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($" {i + 1} - {inventory[i]}".PadRight(31, ' ') + ""); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");

        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" Пусто".PadRight(31, ' '));
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("       │");
    }
    Console.WriteLine("├───────────────────────────────────────┤");


    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ ");
    Console.ForegroundColor = ConsoleColor.White; Console.Write("ОРУЖИЕ: ");
    if (status != "") { Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($"{status} "); } else { Console.ForegroundColor = classColor; }
    Console.Write(weapontype);
    Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("".PadLeft(31 - (status.Length + weapontype.Length + (status != "" ? 2 : 1))) + "│");

    Console.WriteLine("└───────────────────────────────────────┘");
    Console.ResetColor();
}
public enum Difficulty : byte { Easy = 1, Medi, Hard }