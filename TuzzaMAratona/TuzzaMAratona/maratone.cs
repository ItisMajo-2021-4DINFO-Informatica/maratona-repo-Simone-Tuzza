using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TuzzaMAratona
{
    class maratone
    {
        public List<maratona> elencomaratone;

        public maratone()
        {
            elencomaratone = new List<maratona>();
        }

        public void Aggiungi(maratona maratona)
        {
            elencomaratone.Add(maratona);
        }

        public void LeggiDati()
        {
            using (FileStream flussoDati = new FileStream("file.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        maratona maratona = new maratona();
                        maratona.NomeAtleta = campi[0];
                        maratona.Societa = campi[1];
                        maratona.Tempo = campi[2];
                        maratona.Citta = campi[3];


                        Aggiungi(maratona);

                    }
                }
            }
        }

        public string CercaAtleta(string nome, string citta)
        {
            string artista = "";

            foreach (var maratona in elencomaratone)
            {
                if (maratona.NomeAtleta == nome && maratona.Citta == citta)
                {
                    artista = maratona.Tempo;
                }
            }

            return artista;
        }
    }
}

