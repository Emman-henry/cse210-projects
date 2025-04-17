namespace ConsoleApp1
{
    public abstract class Runner
    {
        protected string _Gname { get; set; }
        protected string _Descrip { get; set; }
        protected string _Point { get; set; }

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
