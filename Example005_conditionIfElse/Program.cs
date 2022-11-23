Console.WriteLine("Введите имя пользователя");
string userName = Console.ReadLine();

if (userName.ToLower() =="даша")
{
    Console.WriteLine("Ура, это же ДАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}