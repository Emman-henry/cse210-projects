namespace ConsoleApp1
{
    public class SimpleGoal : Runner
    {
        private bool _completed = false;

        public SimpleGoal(string gname, string descrip, string point)
            : base(gname, descrip, point)
        {
        }

        public override int RecordProgress()
        {
            if (!_completed)
            {
                _completed = true;
                return int.Parse(Point);
            }
            else
            {
                Console.WriteLine("This goal is already completed.");
                return 0;
            }
        }

        public override string ToString()
        {
            string check = _completed ? "X" : " ";
            return $"[{check}] {Gname}, {Descrip}, {Point}";
        }
    }
}
