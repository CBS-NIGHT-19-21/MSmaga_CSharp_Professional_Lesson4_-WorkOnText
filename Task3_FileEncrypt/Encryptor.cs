static class Encryptor
{
    public static void Encrypt(this FileInfo fileInfo, List<string> prepositionList, string crypt)
    {
        if (fileInfo.Exists)
        {
            try
            {
                string[] fileLines = File.ReadAllLines(fileInfo.FullName);

                for (int i = 0; i < fileLines.Length; i++)
                {
                    foreach (string prep in prepositionList)
                    {
                        fileLines[i] = fileLines[i].Replace(prep, crypt);
                    }
                    Console.WriteLine(fileLines[i]);
                }

                File.WriteAllLines(fileInfo.FullName, fileLines);
                Console.WriteLine("The file has been encrypted successfully!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
