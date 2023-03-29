public class SimpleGoal : Goals
{

    public SimpleGoal(string name  = "Name", string description = "Description", string points  = "0", bool finished  = false, bool eternal = false) : base(name, description, points, finished, eternal)
    {
    }

    public override int DoGoal(bool decide) 
    {
        int points = 0;
        if (this._goalFinished == true)
        {
            Console.WriteLine("Hey!, don't realized it but you already completed this goal. Keep it up!");
        } else
        {
        points = int.Parse(_goalPoints);
        }
        _goalFinished = decide; 
        return points;
    }
}