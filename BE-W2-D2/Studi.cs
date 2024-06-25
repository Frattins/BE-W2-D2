namespace BE_W2_D2
{
    public class Studi
    {
        public string Istituzione { get; set; }
        public string Tipo { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public override string ToString()
        {
            return $"Istituto: {Istituzione}\nTipo: {Tipo}\nDal: {DataInizio} al {DataFine}";
        }
    }
}
