namespace GitExercise
{
    class myClass
    {
        private string navn;
        private string adresse;
        private int postnr;

        public string Navn {get; set;}
        public string Adresse {get; set;}
        public int Postnr {get; set;}

        public myClass(string Navn, string Adresse, int Postnr)
        {
            Navn = navn;
            Adresse = adresse;
            postnr = Postnr;
        }
    }
}