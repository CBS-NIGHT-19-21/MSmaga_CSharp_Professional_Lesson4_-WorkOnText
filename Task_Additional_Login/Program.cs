namespace LoginPassCheck
{
    class Program
    {
        static void GetLoginPass()
        {
            Console.Write("Login: ");
            string login = Console.ReadLine()!;

            if (login.IsLatin())
            {
                Console.Write("Password: ");
                string password = Console.ReadLine()!;
                if (password.IsNumSymb())
                {
                    Console.WriteLine("You have created your Login and Password successfully!");
                }
                else { Console.WriteLine("The Password should consist Numbers or Symbols only!"); }
            }
            else { Console.WriteLine("The Login should consist Latin letters only!"); }
        }
        static void Main()
        {
            GetLoginPass();

            Console.ReadLine();
        }
    }
}
