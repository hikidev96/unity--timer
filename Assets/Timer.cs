using System;
using System.Threading.Tasks;

public class Timer
{
    public void AddAlarm(float time, Action action)
    {
        Alarm(time, action);
    }

    private async void Alarm(float time, Action action)
    {
        await Task.Delay((int)(time * 1000.0f));
        action();
    }
}
