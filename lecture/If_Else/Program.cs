Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "даша")
{
    Console.WriteLine("Ура, это же ДАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
