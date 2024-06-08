using UnityEngine;

public class TimerTester : MonoBehaviour
{
    private Timer timer = new Timer();

    private void Start()
    {
        timer.AddAlarm(1.0f, () => Debug.Log("Here!"));
    }
}
