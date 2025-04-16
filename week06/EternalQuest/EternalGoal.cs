namespace ConsoleApp1
{
    public class EternalGoal : Runner
    {
        public EternalGoal(string gname, string descrip, string point)
            : base(gname, descrip, point)
        {
        }

        public override int RecordProgress()
        {
            return int.Parse(Point);
        }

        public override string ToString()
        {
            return $"[∞] {Gname}, {Descrip}, {Point}";
        }
    }
}
