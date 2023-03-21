Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет, красотка! Как твой настрой? Проходи!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}