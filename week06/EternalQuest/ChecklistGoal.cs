public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    private int _completedCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int completedCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _completedCount = completedCount;
    }

    public override int RecordEvent()
    {
        if (_completedCount < _targetCount)
        {
            _completedCount++;
            if (_completedCount == _targetCount)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _completedCount >= _targetCount;

    public override string GetStatus() => IsComplete() ? "[X]" : $"[{_completedCount}/{_targetCount}]";

    public override string Serialize()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonus}|{_completedCount}";
    }
}
