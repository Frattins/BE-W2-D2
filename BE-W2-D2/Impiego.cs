namespace BE_W2_D2
{
    public class Impiego
    {
        public string Azienda { get; set; }
        public string Ruolo { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public string Compiti { get; set; }

        public override string ToString()
        {
            return $"Azienda: {Azienda}\nRuolo: {Ruolo}\nCompiti: {Compiti}\nDal: {DataInizio} al {DataFine}";
        }
    }
}
