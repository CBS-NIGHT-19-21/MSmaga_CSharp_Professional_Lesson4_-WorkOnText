
using System.Globalization;

namespace Task4_FileCheck
{
    public class Check
    {
        private List<Good> _goodsList = new List<Good>();

        public void Add(Good good)
        {
            _goodsList.Add(good);
        }
        public void PrintToFile(string filePath)
        {
            StreamWriter stream;
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists) File.Delete(fileInfo.FullName);
            stream = fileInfo.AppendText();

            stream.WriteLine(DateTime.Now);
            _goodsList.ForEach(good => stream.WriteLine($"\n{good.Name} \t- {good.Price}"));
            stream.Close();
        }

        public void Show()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Текущая локаль: {0}.", currentCulture);
            Console.WriteLine(DateTime.Now);
            _goodsList.ForEach(good => Console.WriteLine($"\n{good.Name} \t- {good.Price}"));

        }
    }
}
