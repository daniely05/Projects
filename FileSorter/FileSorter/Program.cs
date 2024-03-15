using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
class Program 
{
    static void Main()
    {
        string localPath = "C:\\Users\\danie\\";
        
        Console.WriteLine("Location: (for example: Documents\\HoGent\\)");
        string fileLoc = Console.ReadLine();
        fileLoc = fileLoc + "\\";
        Console.WriteLine("File name: (for example: lifeGoals.txt)");
        string fileName = Console.ReadLine();
        Console.WriteLine("Subject name: ");
        string subject = Console.ReadLine();
        string dirPath = $"C:\\Users\\danie\\Documents\\HoGent\\Graduaat_1\\{subject}\\";
        CopyFile(localPath, fileLoc, fileName, dirPath);

        

    }
    static void CopyFile(string localPath, string fileLoc, string fileName, string dirPath)
    {
        string filePath = Path.Combine(localPath, fileLoc, fileName);
        if (Directory.Exists(dirPath) == false)
        {
            Directory.CreateDirectory(dirPath);

        }
        if (File.Exists(filePath) == false)
        {
            File.Copy(filePath, Path.Combine(dirPath, Path.GetFileName(filePath)));

        }
        else if (File.Exists(filePath) == true)
        {
            Console.WriteLine("File exists. Do you want to copy anyway? (Y/N)");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'Y')
            {
               
                File.Copy(filePath, Path.Combine(dirPath, Path.GetFileName(filePath)), true);
                

            }
            else return;
        }
        
        
        
            
        

        string check = "Done.";
        Console.WriteLine(check);
        Console.ReadLine();
        
    }

}
