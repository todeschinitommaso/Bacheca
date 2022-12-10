using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachecaTodeschini
{
    public class Bacheca
    {

        private const int massimo = 999; //n massimo di annunci

        private string _id;

        private annuncio[] _annunci = new annuncio[massimo];

        //GET e SET
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("ID non valido");
            }
        }

        public Bacheca(string id)
        {
            this.Id = id;
            Svuota();
        }

        private int getNumAnnunci() //numero di annunci all'interno della bacheca
        {
            int i = 0;
            while (i < _annunci.Length && _annunci[i] != null)
            {
                i++;
            }

            if (i != _annunci.Length)
                return i;
            else
                throw new Exception("La bacheca é piena");
        }


        public void Aggiungi(annuncio a) //aggiungi annuncio
        {
            if (a != null)
                _annunci[getNumAnnunci()] = a;
            else
                throw new Exception("Inserire un annuncio valido");
        }

        public void Svuota() //svuota bacheca
        {
            for(int i = 0; i < massimo; i++)
                _annunci[i] = null;
        }

        public annuncio GetAnnuncio(int i)
        {
            return _annunci[i];
        }

        public int Cerca(annuncio a) //ricerca annuncio
        {
            int pos = -1;
            for (int i = 0; i < massimo; i++)
            {
                if (_annunci[i] == a)
                {
                    pos = i;
                }
            }
            return pos;
        }

        //RICERCA TRAMITE ID
        public string[] CercaID(string id)
        {

            string[] stringa = new string[4];

            for (int i = 0; i < massimo; i++)
            {
                if (_annunci[i] != null)
                {
                    if (_annunci[i].Id == id)
                    {
                        stringa[0] = _annunci[i].Nome;
                        stringa[1] = _annunci[i].Descrizione;
                        stringa[2] = _annunci[i].Prezzo.ToString();
                        stringa[3] = _annunci[i].Data;
                    }
                }
            }
            return stringa;
        }

        //ELIMINAZIONE 
        public void Elimina(string id)
        {
            for (int i = 0; i < massimo; i++)
            {
                if (_annunci[i] != null)
                {
                    if (_annunci[i].Id == id)
                    {
                        _annunci[i] = null;
                    }
                }
            }
        }

        public void Modifica(string id, annuncio input)
        {
            for (int i = 0; i < massimo; i++)
            {
                if (_annunci[i] != null)
                {
                    if (_annunci[i].Id == id)
                    {
                        _annunci[i] = null;
                        _annunci[i] = input;
                    }
                }
            }
        }
    }
}
