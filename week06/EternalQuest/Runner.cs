namespace ConsoleApp1
{
    public abstract class Runner
    {
        protected string _gname;
        protected string _descrip;
        protected string _point;

        public Runner(string gname, string descrip, string point)
        {
            _gname = gname;
            _descrip = descrip;
            _point = point;
        }

        public abstract int RecordProgress();

        public override string ToString()
        {
            return $"[ ] {_gname}, {_descrip}, {_point}";
        }
    }
}
