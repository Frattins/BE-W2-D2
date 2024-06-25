namespace BE_W2_D2
{
    public class Esperienza
    {
        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public override string ToString()
        {
            return $"Titolo: {Titolo}\nDescrizione: {Descrizione}\nDal: {DataInizio} al {DataFine}";
        }
    }
    }
