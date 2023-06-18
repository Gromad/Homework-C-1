// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine()!);
if(numberOne > numberTwo && numberOne > numberThree)
{
        Console.WriteLine("Максимальное число: "+numberOne);
}
   
if(numberTwo > numberOne && numberTwo > numberThree)
    {
        Console.WriteLine("Максимальное число: "+numberTwo);
    }
if(numberThree > numberOne && numberThree > numberTwo)
    {
        Console.WriteLine("Максимальное число: "+numberThree);
    } 
if(numberOne == numberTwo && numberTwo == numberThree)
{
 Console.WriteLine("Все числа равны");   
}
