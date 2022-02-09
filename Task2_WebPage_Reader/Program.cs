
using System.Net;

class Program
{
    static List<string> GetLinks(string htmlText)
    {
        List<string> arrayStr = new List<string>();

        while (htmlText.IndexOf(" href=") > 0)
        {
            htmlText = htmlText.Remove(1, htmlText.IndexOf(" href=") + 6);
            string addStr = htmlText.Substring(0, htmlText.IndexOf(" "));
            bool isLink = addStr != "#" && addStr != "" && addStr != " ";
            if (isLink) arrayStr.Add(addStr);
        }
        File.WriteAllLines(@"D:\Links.txt", arrayStr);
        return arrayStr;
    }
    static List<string> GetEmails(string htmlText)
    {
        List<string> arrayStr = new List<string>();

        while (htmlText.IndexOf("mailto:") > 0)
        {
            htmlText = htmlText.Remove(1, htmlText.IndexOf("mailto:") + 6);
            string addStr = htmlText.Substring(0, htmlText.IndexOf("\""));
            bool isLink = addStr != "#" && addStr != "" && addStr != " ";
            if (isLink) arrayStr.Add(addStr);
        }
        if (arrayStr.Count > 0)
        File.WriteAllLines(@"D:\Emails.txt", arrayStr);
        return arrayStr;
    }
    static List<string> GetTels(string htmlText)
    {
        List<string> arrayStr = new List<string>();

        while (htmlText.IndexOf("tel:") > 0)
        {
            htmlText = htmlText.Remove(1, htmlText.IndexOf("tel:") + 4);
            string addStr = htmlText.Substring(0, htmlText.IndexOf("\""));
            bool isLink = addStr != "#" && addStr != "" && addStr != " ";
            if (isLink) arrayStr.Add(addStr);
        }
        if (arrayStr.Count > 0)
            File.WriteAllLines(@"D:\Tels.txt", arrayStr);
        return arrayStr;
    }

    static void Main()
    {
        try
        {
            WebClient client = new WebClient();
            string content = client.DownloadString("https://www.hatch.com/");

            GetLinks(content);
 
            GetEmails(content);

            GetTels(content);

            Console.WriteLine("Statistic have been downloaded!");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}