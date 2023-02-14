int num1 = new Random().Next(11, 101);
int num2 = new Random().Next(1, 11);


if(num1 % num2 == 0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine($"Числа не кратны остаток от деления :{num1 % num2}");
}
Console.WriteLine($"{num1}   {num2}");