Console.WriteLine("Приветствую Вас в программе для решения задачи с гирями из курса Введение в программирование ");
Console.WriteLine("Введите вес гири №1 ");
int w1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вес гири №2 ");
int w2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вес гири №3 ");
int w3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вес гири №4 ");
int w4 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вес гири №5 ");
int w5 = int.Parse(Console.ReadLine());

int max = w1;

if(w1 > max) max = w1;
if(w2 > max) max = w2;
if(w3 > max) max = w3;
if(w4 > max) max = w4;
if(w5 > max) max = w5;

Console.Write("Максимальное значение max = ");
Console.WriteLine(max);
