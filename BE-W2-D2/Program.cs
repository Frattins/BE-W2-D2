using BE_W2_D2;
using System;

namespace GestioneCV
{
    class Program
    {
        static void Main(string[] args)
        {
            var cv = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Nome = "Marco",
                    Cognome = "Puccio",
                    Email = "info@marcopuccio.com",
                    Telefono = "+393288317446"
                }
            };

            cv.StudiEffettuati.Add(new Studi
            {
                Istituzione = "UniPa",
                Tipo = "Laurea",
                DataInizio = new DateTime(2016, 12, 10),
                DataFine = new DateTime(2019, 7, 22)
            });

            cv.StudiEffettuati.Add(new Studi
            {
                Istituzione = "Microsoft Center Milan",
                Tipo = "Specializzazione sviluppo software",
                DataInizio = new DateTime(2016, 9, 12),
                DataFine = new DateTime(2019, 7, 22)
            });

            cv.Impieghi.Add(new Impiego
            {
                Azienda = "Libero Professionista",
                Ruolo = "IT Manager",
                DataInizio = new DateTime(2016, 9, 12),
                DataFine = new DateTime(2016, 9, 12),
                Compiti = "Sviluppatore software"
            });

            cv.Impieghi.Add(new Impiego
            {
                Azienda = "Libero Professionista",
                Ruolo = "Docenza e Formazione",
                DataInizio = new DateTime(2016, 9, 12),
                DataFine = new DateTime(2016, 9, 12),
                Compiti = "Docente e Formatore"
            });

            cv.StampaDettagliCVSuSchermo();
        }
    }
}
