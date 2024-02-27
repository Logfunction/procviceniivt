using System.ComponentModel;
using System.ComponentModel.Design;

Console.WriteLine("zadej dvojici čísel a nuly");
int x;
int y;
int max = 0;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
while (x!=0 && y != 0)
{
    if (x + y > max)
    {
        max = x + y;
    }

    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());

}

Random random = new Random();
int r = random.Next(0, 100);

if (r > max)
{
    Console.WriteLine("součet je menší, než náhodné číslo");
}
else
{
    Console.WriteLine("součet je menší, než náhodné číslo");
}

Console.WriteLine("nejvetsi soucet je " + max);