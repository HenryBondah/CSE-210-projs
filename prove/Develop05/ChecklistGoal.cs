public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal()
    {
        CompletedCount = 0;
    }

    public override void MarkComplete()
    {
        CompletedCount++;
        if (CompletedCount >= TargetCount)
        {
            IsCompleted = true;
            Points += BonusPoints;
        }
    }

    public override void DisplayProgress()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} ({CompletedCount}/{TargetCount} completed, {Points} points)");
    }
}