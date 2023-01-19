Console.Write("Введите первое число: ");
int numa = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numb = int.Parse(Console.ReadLine()!);
// int numa = 9;
// int numb = 7;
if (numa > numb) 
{
  Console.Write("max = " + numa);
} else if (numa < numb) 
{ 
  Console.Write("max = " + numb);
} else Console.Write("значения равны");
