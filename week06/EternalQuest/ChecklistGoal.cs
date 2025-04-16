namespace ConsoleApp1
{
    public class ChecklistGoal : Runner
    {
        public int TimesToComplete { get; set; }
        public int CompletionCount { get; set; } = 0;

        public ChecklistGoal(string gname, string descrip, string point, int timesToComplete)
            : base(gname, descrip, point)
        {
            TimesToComplete = timesToComplete;
        }

        public override int RecordProgress()
        {
            if (CompletionCount < TimesToComplete)
            {
                CompletionCount++;
                return int.Parse(Point);
            }
            else
            {
                Console.WriteLine("✔️ Checklist already complete.");
                return 0;
            }
        }

        public override string ToString()
        {
            string check = CompletionCount >= TimesToComplete ? "X" : " ";
            return $"[{check}] {Gname}, {Descrip}, {Point} ({CompletionCount}/{TimesToComplete})";
        }
    }
}
