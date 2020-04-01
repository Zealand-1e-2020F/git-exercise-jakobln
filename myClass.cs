namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _adresse;
        private int _postnr;

        public string Navn 
        {
            get {return _navn;}
        }
        public string Adresse 
        {
            get {return _adresse;}
        }
        public int Postnr
        {
            get {return _postnr;}
        }

        public myClass(string Navn, string Adresse, int Postnr)
        {
            _navn = Navn;
            _adresse = Adresse;
            _postnr = Postnr;
        }

        public override string ToString()
        {
            return Navn + " " + Adresse + " " + Postnr;
        }
    }
}