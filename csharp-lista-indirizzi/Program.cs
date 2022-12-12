// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;

string pathFile = "C:\\Users\\Fran_\\Desktop\\Esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\files\\addresses.csv";

StreamReader file = File.OpenText(pathFile);

int rigacorrente=0;
List<Indirizzo> listaIndirizzi= new List<Indirizzo>();

while (!file.EndOfStream)
{
    rigacorrente++;
    string line = file.ReadLine();
    if (rigacorrente != 1)
    {
        Console.WriteLine(line);
        string[] Listainformazioni = line.Split(',');
        int numeroInformazioni = (Listainformazioni.Length);
        if (numeroInformazioni < 6)
        {
            Console.WriteLine("L'indirizzo a riga " + rigacorrente + " non presenta tutte le informazioni necessarie né la giusta formattazione");
        }
        else
        {
            for (int i = 0; i < Listainformazioni.Length; i++)
            {
                if (Listainformazioni[i]==null || Listainformazioni[i] == "")
                {
                    Listainformazioni[i] = "undefined";
                }
            }
            Indirizzo indirizzo = new Indirizzo(Listainformazioni[0], Listainformazioni[1], Listainformazioni[2], Listainformazioni[3], Listainformazioni[4], Listainformazioni[5]);
            listaIndirizzi.Add(indirizzo);
        }
    }
    
}

file.Close();

Console.WriteLine(listaIndirizzi[5]);