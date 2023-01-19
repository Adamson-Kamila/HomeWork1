Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);


if (num1 > num2 && num1 > num3) 
{
  Console.Write("max = " + num1);
} 

if (num2 > num1 && num2 > num3) 
{ 
  Console.Write("max = " + num2);
} 

if (num3 > num1 && num3 > num2) 
{
  Console.Write("max = " + num3);
}

if (num1 == num2 && num1 == num3)
{
   Console.Write("значения равны");
}








