namespace FileEncryptor
{
    class Program
    {
        static void Main()
        {
            List<string> prepositionList = new List<string>()
        { " без ", " безо ", " близ ", " в ", " во ", " вместо ", " вне ", " для ", " до ", " за ", " из ", " изo ",
          " из-за ", " из-под ", " к ", " ко ", " кроме ", " между ", " меж ", " на ", " над ", " надо ", " о ",
          " об ", " обо ", " от ", " ото ", " перед ", " передо ", " пред ", " пo ", " под ", " подо ", " при ",
          " про ", " ради ", " с ", " со ", " во ", " сквозь ", " среди ", " у ", " через ", " чрез "
        };

            FileInfo fileInfo = new FileInfo(@"D:\AnnaKarenina.txt");

            fileInfo.Encrypt(prepositionList, " WOOF! ");
            

            Console.ReadLine();
        }
    }
}
