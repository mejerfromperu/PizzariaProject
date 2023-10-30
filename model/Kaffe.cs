namespace PizzariaProject.model
{
    public class Kaffe
    {
        /*
         * Instans Feleter
         */
        private string _land;
        private string _sort;
        private double _pris; // skal være nul eller over
        private string _ristningsgrad;


        /*
         * Properties
         */
        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }

        public string Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set
            {
                if (!(value >= 0))
                {
                    throw new ArgumentException("Pris skal være nul eller positiv men var " + value);
                }

                _pris = value;
            }
        }
        public string Ristningsgrad
        {
            get { return _ristningsgrad; }
            set { _ristningsgrad = value; }
        }



        /*
         * Constructor - kaldes kun een gang - når objektet laves
         */

        public Kaffe() // default
        {
            _land = "";
            _sort = "";
            _pris = 0;
            _ristningsgrad = "";
        }

        public Kaffe(string land, string sort, double pris, string ristningsgrad)
        {
            _land = land;
            _sort = sort;
            _pris = pris;
            _ristningsgrad = ristningsgrad;
        }




        /*
         * metoder
         */

        public double PrisMedMoms()
        {
            double prisMedMoms = _pris * 1.25;
            return prisMedMoms;
        }


        public override string ToString()
        {
            return $"{{{nameof(Land)}={Land}, {nameof(Sort)}={Sort}, {nameof(Pris)}={Pris.ToString()}, {nameof(Ristningsgrad)}={Ristningsgrad}}}";
        }
    }
}
