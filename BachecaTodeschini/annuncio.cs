using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachecaTodeschini
{
    public class annuncio
    {

        private string _id;

        private string _nome;

        private string _descrizione;

        private string _data;

        private float _prezzo;

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

        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (value != null)
                    _nome = value;
                else
                    throw new Exception("Nome non valido");
            }
        }

        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            private set
            {
                if (value != null)
                    _descrizione = value;
                else
                    throw new Exception("Descrizione non valida");
            }
        }

        public string Data
        {
            get
            {
                return _data;
            }
            private set
            {
                if (value != null)
                    _data = value;
                else
                    throw new Exception("Data non valida");
            }
        }

        public float Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if(value < 0)
                    throw new Exception("Prezzo non valido");
                else
                _prezzo = value;
            }
        }
        //

        //DICHIARAZIONE COSTRUTTORE
        public annuncio(string id, string nome, string desc, string data, float prezzo)
        {
            Id = id;
            Nome = nome;
            Descrizione = desc;
            Data = data;
            Prezzo = prezzo;
        }

        //CONVERSIONE A STRING (PER RISOLVERE UN ERRORE)
        public string[] ToString()
        {
            string[] p = { Id, Nome, Descrizione, Data, Convert.ToString(Prezzo) };
            return p;
        }
    }
}
