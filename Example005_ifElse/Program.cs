Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "наташа") {
   Console.Write("Приет моя любимая, Наташа!!!");
}
else {
  Console.Write("Приет, "); Console.Write(userName);  
}
