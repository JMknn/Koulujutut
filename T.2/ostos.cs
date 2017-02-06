namespace T2
{
    class Ostos
    {
        public string Nimi { get; set; }

        public float Hinta { get; set; }

        public Ostos(string nimi, float hinta)
        {

            Nimi = nimi;

            Hinta = hinta;
        }
            public override string ToString()
        {
            return "Ostos " + Nimi + " " + Hinta + " euroa";
        }
    }
    
}
