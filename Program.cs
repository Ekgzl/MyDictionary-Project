namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
        
        myDictionary.Add("Enes",2022);
        myDictionary.Add("Kaan",2023);
        myDictionary.Add("Kerem",2024);
        Console.WriteLine(myDictionary.Count());
        myDictionary.Show("Enes");
        myDictionary.RemoveAt("Enes");
        myDictionary.Show("Enes");
        myDictionary.Show("Kerem");
        myDictionary.Add("Erdem",2025);
        myDictionary.Show("Erdem");

        Console.ReadLine();
    }
}