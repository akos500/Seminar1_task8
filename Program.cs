// Программа, принимающая на вход число N и на выходе показывает
// все четные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = 1;
   
if (result == 1)

{
    result += 1;
}

while (result <= num)

{
    Console.WriteLine(result);
    result += 2;
}