namespace _2M_11_Instrument_polimorfizm
{
    class Instrument
    {
        private string nazwa;
        public Instrument(string nazwa) => this.nazwa = nazwa;
        public virtual void graj()
        {
            ;
        }
        public override string ToString()
        {
            return nazwa;
        }

    }
    class InstrumentStrunowy : Instrument
    {
        private string dzwiek = "brzdek brzdęk brzedeęęęęk";
        public InstrumentStrunowy(string nazwa) : base(nazwa)
        {
            //tu może być np strojenie gitary
        }
        public override void graj()
        {
            Console.WriteLine(dzwiek);
        }
        public override string ToString()
        {
            return base.ToString()+ $" gra {dzwiek}";
        }

    }
    class InstrumentDety : Instrument
    {
        private string dzwiek = "Ttrutututuuuuu truuuuuuu";
        public InstrumentDety(string nazwa) : base(nazwa)
        {
            //tu może być coś...
        }
        public override void graj()
        {
            Console.WriteLine(dzwiek);
        }
        public override string ToString()
        {
            return base.ToString() + $" gra {dzwiek}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Instrument[] zespol = new Instrument[2];
            InstrumentDety trabka = new InstrumentDety("trąbka");
            InstrumentStrunowy gitara = new InstrumentStrunowy("gitara");
            zespol[0] = trabka;
            zespol[1] = gitara;

            Console.WriteLine("w zespole gra:");
            foreach (Instrument inst in zespol)
                Console.Write(inst + " ");
            Console.WriteLine("\ndźwięki:");
            foreach (Instrument inst in zespol)
                inst.graj();
        }
    }
}