namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _adresse;
        private int _postnr;
        private string _by;

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
        public string By
        {
            get {return _by;}
        }

        public myClass(string Navn, string Adresse, int Postnr, string By)
        {
            _navn = Navn;
            _adresse = Adresse;
            _postnr = Postnr;
            _by = By;
        }

        public override string ToString()
        {
            return Navn + " " + Adresse + " " + Postnr + " " + By;
        }
    }
}