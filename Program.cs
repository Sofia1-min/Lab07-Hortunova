//Задание 1.1.
/*string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт","Сб","Вс" };
for (int i = 6; i >= 0; i--)
{
    Console.WriteLine($"{i}: {days[i]}");
}*/
//Задание 1.2
/*double[] temps = { 0, 15, -5, 10, 5, -1, 20 };
foreach (double i in temps)
{
    Console.Write($"{i} ");
}*/
// Задание 2
/*int[] prices = { 120, 45, 300, 80, 15, 210 };
int sum = 0;
int count = 0;
foreach (int price in prices)
{
    sum += price;
    if (price > 100)
    {
        count += 1;
    }
}
double average = (double)sum / prices.Length;
Console.WriteLine($"Сумма: {sum}, Количество товаров дороже 100: {count}, среднее {average}");*/
// Задание 3
/*int[] prices = { 120, 45, 300, 80, 15, 210 };
int max = prices[0];
int min = prices[0];
int a = 0;
for (int i = 1; i < 6; i++)
{
    if (prices[i] > max)
    {
        a = i;
        max = prices[i];
    }
    if (prices[i] < min)
    {
        min = prices[i];
    }
}
Console.WriteLine($"минимум — {min}, индекс самого дорогого—{a}.");*/
//Задание 4
/*int[] balance = { 100, -50, 20, -5, 0, 75 };
for (int i = 0; i < 6;i++)
{
   if  (balance[i] < 0)
    {
        balance[i] = 0;
    }
}
foreach ( int n in balance)
{
    Console.Write(n + " ");
}*/
// Задание 5
/*int[] numbers = new int[5];
for (int i = 0; i < 5; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
foreach ( int n in numbers)
{
    Console.Write(n + " ");
}
int count = 0;
for (int i = 0; i < 5; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");*/
// Задание 6
/*string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

int pos = 0;

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == name)
            {
                pos = i + 1;
                break;
            }
        }

        if (pos == 0)
        {
            Console.WriteLine("Не найдено");
        }
        else
        {
            Console.WriteLine("Позиция: " + pos);
        }*/
// Задание Итоговая задача. «Журнал оценок»
/*int[] a = { 4, 5, 3, 2, 5, 4, 5, 3 };

int b = 0;
int c = a[0];
int d = a[0];
int e = 0;
int f = 0;

for (int i = 0; i < 8; i++)
{
    Console.Write($"{a[i]} ");
    b += a[i];

    if (a[i] < c)
    {
        c = a[i];
    }

    if (a[i] > d)
    {
        d = a[i];
    }

    if (a[i] == 2)
    {
        e += 1;
    }

    if (a[i] == 5)
    {
        f += 1;
    }
}

double g = (double)b / 8;

Console.WriteLine($"Средняя: {g}");
Console.WriteLine($"Максимум: {d}, Минимум: {c}");
Console.WriteLine($"Двоек: {e}, Пятерок: {f}");

if (g >= 4.5)
{
    Console.WriteLine("Отличник");
}
else if (g >= 3.5)
{
    Console.WriteLine("Хорошист");
}
else
{
    Console.WriteLine("Есть над чем поработать");
}*/
// Дополнительное задание ★★★
int[] a = { 1, 2, 3, 4, 5, 6 };

for (int i = 0; i < 3; i++)
{
    int b = a[i];
    a[i] = a[5 - i];
    a[5 - i] = b;
}

for (int i = 0; i < 6; i++)
{
    Console.Write($"{a[i]} ");
}