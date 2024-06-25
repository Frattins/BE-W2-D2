namespace BE_W2_D2
{
    public class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCognome: {Cognome}\nEmail: {Email}\nTelefono: {Telefono}";
        }
}
}
