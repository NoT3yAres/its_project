using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace FileSystem
{
    class NodoFileSystem
    {
        public string Nome { get; set; }
        public int Dimensione { get; set; }
        public NodoFileSystem Genitore { get; set; }
        public List<NodoFileSystem> Figli { get; set; }

        public NodoFileSystem(string p_nome = "C:/", int p_dimensione = 0)
        {
            Nome = p_nome;
            Dimensione = p_dimensione;
            Figli = new List<NodoFileSystem>();
        }
        public NodoFileSystem AggiungiNodo(NodoFileSystem genitore)
        {
            Genitore = genitore;
            return Genitore;
        }

        public NodoFileSystem AggiungiFile(string nome, int dimensione)
        {
            NodoFileSystem File = new NodoFileSystem(nome, dimensione);
            File.Genitore = Genitore;
            Figli.Add(File);
            return File;
        }

        public NodoFileSystem AggiungiFolder(string nome)
        {
            NodoFileSystem Folder = new NodoFileSystem(nome);
            Folder.Genitore = Genitore;
            Figli.Add(Folder);
            return Folder;
        }

        public void StampaChildren()
        {

            foreach (var figlio in Figli)
            {

                if (isFile(figlio))
                    Console.Write($"\t");

                Console.WriteLine($"\t{figlio.Nome}\t{figlio.Dimensione}");
                figlio.StampaChildren();
            }
        }

        public void SelfStampa()
        {
            Console.WriteLine($"{Nome}\t{Dimensione}");
        }

        public static bool isFile(NodoFileSystem nodo)
        {
            if ((nodo.Figli.Count == 0) && (nodo.Dimensione > 0)) return true;
            else return false;
        }

        public static bool TrovaFile(NodoFileSystem nodo, string nome)
        {
            foreach (var figlio in nodo.Figli)
            {

                if (nodo.Nome == nome)
                    return true;
                TrovaFile(figlio, nome);
            }
            return false;
        }
    }
}