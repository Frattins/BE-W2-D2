using System;


namespace BE_W2_D2
{
    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impiego> Impieghi { get; set; }
        public List<Esperienza> Esperienze { get; set; }

        public CV()
        {
            StudiEffettuati = new List<Studi>();
            Impieghi = new List<Impiego>();
            Esperienze = new List<Esperienza>();
        }

        public void StampaDettagliCVSuSchermo()
        {
            Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
            Console.WriteLine(InformazioniPersonali);
            Console.WriteLine("++++ FINE Informazioni Personali: ++++");

            Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
            foreach (var studio in StudiEffettuati)
            {
                Console.WriteLine(studio);
            }
            Console.WriteLine("++++ FINE Studi e Formazione: ++++");

            Console.WriteLine("++++ INIZIO Impieghi: ++++");
            foreach (var impiego in Impieghi)
            {
                Console.WriteLine(impiego);
            }
            Console.WriteLine("++++ FINE Impieghi: ++++");

            Console.WriteLine("++++ INIZIO Esperienze: ++++");
            foreach (var esperienza in Esperienze)
            {
                Console.WriteLine(esperienza);
            }
            Console.WriteLine("++++ FINE Esperienze: ++++");
        }
    }
}

