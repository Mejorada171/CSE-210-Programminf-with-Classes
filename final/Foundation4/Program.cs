using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        _activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0));
        _activities.Add(new CyclingActivity(new DateTime(2022, 11, 3), 30, 12.0));
        _activities.Add(new SwimmingActivity(new DateTime(2022, 11, 3), 30, 60));

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}