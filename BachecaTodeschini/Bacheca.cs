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

        //NUMERO DI ANNUNCI PRESENTI IN BACHECA
        private int getNumAnnunci()
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

        //AGGIUNTA ANNUNCIO
        public void Aggiungi(annuncio a) 
        {
            if (a != null)
                _annunci[getNumAnnunci()] = a;
            else
                throw new Exception("Inserire un annuncio valido");
        }

        //SVUOTA BACHECA
        public void Svuota() 
        {
            for(int i = 0; i < massimo; i++)
                _annunci[i] = null;
        }

        public annuncio GetAnnuncio(int i)
        {
            return _annunci[i];
        }

        //RICERCA DI UN ANNUNCIO
        public int Cerca(annuncio a) 
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

        //BUBBLE SORT
        public void Ordinamento()
        {
            int n = getNumAnnunci();
            annuncio temp;

            for (int j = 0; j <= n - 1; j++)
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    if (_annunci[i + 1] != null)
                    {
                        if (_annunci[i].Prezzo > _annunci[i + 1].Prezzo)
                        {
                            temp = _annunci[i + 1];
                            _annunci[i + 1] = _annunci[i];
                            _annunci[i] = temp;
                        }
                    }
                }
            }
        }

        //SOMMA PREZZO
        public float PrezzoTot()
        {
            float tot = 0;

            for(int i = 0; i < _annunci.Length; i++) 
            {   
                if( _annunci[i] != null)
                    tot = tot + _annunci[i].Prezzo;
            }

            return tot;
        }
    }
}