Console.WriteLine("Hej");


namespace Data
{
        public class AnvandareData
    {
        public int AnvandarID { get; }
        public string Fornamn { get; }
        public string Efternamn { get; }
        public string Signatur { get; }
        public long Telefonnr { get; }
        public string Epost { get; }
        public string Lösenord { get; }
        public int Behörighetsgrad { get; }

        public AnvandareData(int anvandarID, string fornamn, string efternamn, string signatur, long telefonnr, string epost, string lösenord, int behörighetsgrad)
        {
            AnvandarID = anvandarID;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Signatur = signatur;
            Telefonnr = telefonnr;
            Epost = epost;
            Lösenord = lösenord;
            Behörighetsgrad = behörighetsgrad;
        }
    }

    public class AnvandareRepository
    {
        private List<AnvandareData> _anvandareLista;

        public AnvandareRepository()
        {
            // Initialize the data
            _anvandareLista = new List<AnvandareData>
            {
                new AnvandareData(1, "Alice", "Andersson", "ALAN", 701234567, "alice.andersson@gmail.com", "1", 3),
                new AnvandareData(2, "Gustav", "Bergström", "GUBE", 732345678, "gustav.bergstrom@protonmail.com", "2", 3),
                new AnvandareData(3, "Kajsa", "Johansson", "KAJO", 763456789, "kajsa.johansson@hb.com", "3", 3),
                new AnvandareData(4, "Gideon", "Lindgren", "GILI", 794567890, "gideon.lindgren@raceoffice.com", "4", 2),
                new AnvandareData(5, "Johannes", "Pettersson", "JOPE", 705678901, "johannes.pettersson@hb.com", "5", 2),
                new AnvandareData(6, "Yasmine", "Nilsson", "YANI", 736789012, "yasmine.nilsson@gu.org", "6", 2),
                new AnvandareData(7, "Rebecka", "Svensson", "RESV", 767890123, "rebecka.svensson@chalmers.net", "7", 1),
                new AnvandareData(8, "Filip", "Olsson", "FIOL", 798901234, "filip.olsson@havard.co", "8", 1),
                new AnvandareData(9, "Millie", "Karlsson", "MIKA", 709012345, "millie.karlsson@cambridge.edu", "9", 1),
                new AnvandareData(10, "Dag", "Hansson", "DAHA", 730123456, "dag.hansson@enterprise.biz", "10", 1),
                new AnvandareData(11, "Ia", "Persson", "IAPE", 761234567, "ia.persson@provider.io", "11", 1)
            };
        }
        public List<AnvandareData> GetAllAnvandare()
        {
            return _anvandareLista;
        }

        Console.WriteLine("Hejsan :D");
}