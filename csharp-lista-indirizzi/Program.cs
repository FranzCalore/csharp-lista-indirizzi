// See https://aka.ms/new-console-template for more information

string pathFile = "C:\\Users\\Fran_\\Desktop\\Esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\files\\addresses.csv";

StreamReader file = File.OpenText(pathFile);

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    Console.WriteLine(line);
}

file.Close();