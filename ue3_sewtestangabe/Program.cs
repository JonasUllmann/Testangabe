namespace ue3_sewtestangabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flight f1 = new Flight("f123", new DateTime(2023, 12, 30, 12, 30, 0), new DateTime(2023, 12, 30, 16, 0, 0));
            Flight f2 = new Flight("f212", new DateTime(2023, 12, 28, 14, 30, 0), new DateTime(2023, 12, 28, 19, 0, 0));

            Console.WriteLine($"Der Flug {f1.Flugnummer} dauert {f1.getFlightTimeMinutes()} Minuten und startet in {f1.getDaystillflight()} Tagen. Ankunft: {f1.Ankunftszeit.ToString("dd.MM.yyyy HH:mm:ss")}");
            Console.WriteLine($"Der Flug {f2.Flugnummer} dauert {f2.getFlightTimeMinutes()} Minuten und startet in {f2.getDaystillflight()} Tagen. Ankunft: {f2.Ankunftszeit.ToString("dd.MM.yyyy HH:mm:ss")}");


        }
    }

    public class Flight
    {

        private string flugnummer; 
        private DateTime abflugszeit;
        private DateTime ankunftszeit;


        public string Flugnummer
        {
            get
            {
                return this.flugnummer;
            }
        }

        public DateTime Ankunftszeit
        {
            get
            {
                return this.ankunftszeit;
            }
        }

        public Flight(string flugnummer, DateTime abflugszeit, DateTime ankunftszeit)
        {
            this.flugnummer = flugnummer;
            this.abflugszeit = abflugszeit;
            this.ankunftszeit = ankunftszeit;
        }

        public double getFlightTimeMinutes()
        {
            TimeSpan flightduration = this.ankunftszeit - this.abflugszeit;

            return flightduration.TotalMinutes;
        }

        public int getDaystillflight()
        {
            TimeSpan daystillflight = abflugszeit - DateTime.Now;
            
            return daystillflight.Days;
        }


    }

}