int numberA = new int();
int numberB = new int();

Console.Write("Введите первое число: ");
numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberB > max) 
{
    max = numberB;
    min = numberA;
    Console.Write("Большее число = ");
    Console.WriteLine(max);
    Console.Write("Меньшее число = ");
    Console.WriteLine(min);
}

else
{
    Console.Write("Большее число = ");
    Console.WriteLine(max);
    Console.Write("Меньшее число = ");
    Console.WriteLine(min);
}
