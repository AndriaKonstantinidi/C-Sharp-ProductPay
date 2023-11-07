//using System.IO;

//string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/Test";

//DirectoryInfo directory = new DirectoryInfo(path);

//if (!directory.Exists)
//    directory.Create();

//var subDir = directory.CreateSubdirectory(directory.Name+@"/SubDir");
//Console.WriteLine(subDir.Parent);

//foreach(var item in Directory.GetLogicalDrives())
//{
//    Console.WriteLine(item);
//}

using ConsoleApp12;

product pd = new product();

pd.MonthlyPay();