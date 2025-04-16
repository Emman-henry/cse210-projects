namespace ConsoleApp1
{
    public abstract class Runner
    {
        public string Gname { get; set; }
        public string Descrip { get; set; }
        public string Point { get; set; }

        public Runner(string gname, string descrip, string point)
        {
            Gname = gname;
            Descrip = descrip;
            Point = point;
        }

        public abstract int RecordProgress();

        public override string ToString()
        {
            return $"[ ] {Gname}, {Descrip}, {Point}";
        }
    }
}
