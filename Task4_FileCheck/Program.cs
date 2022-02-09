using Task4_FileCheck;

class Program
{
    static void Main()
    {
        Check mycheck = new Check();

        mycheck.Add(new Good("Cake", 2.75m));
        mycheck.Add(new Good("Coffee", 2.50m));
        mycheck.Add(new Good("Juice", 5.50m));

        mycheck.PrintToFile(@"D:\Check.txt");
        mycheck.Show();

        Console.ReadLine();
    }
}