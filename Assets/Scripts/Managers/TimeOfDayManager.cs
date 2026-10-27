using UnityEngine;

public class TimeOfDayManager : MonoBehaviour
{
    public float timeOfDay = 0.25f;
    public float minutesPerDay = 15f;
    public float daySpeed = 1f;

    public void UpdateTime()
    {
        timeOfDay += (Time.deltaTime / (minutesPerDay * 60f)) * daySpeed;
        if (timeOfDay >= 1f)
        {
            timeOfDay = 0f;
        }
    }

    public string GetTimeLabel()
    {
        float totalMinutes = timeOfDay * 24f * 60f;
        int hours = Mathf.FloorToInt(totalMinutes / 60f);
        int minutes = Mathf.FloorToInt(totalMinutes % 60f);

        return string.Format("{0:00}:{1:00}", hours, minutes);
    }

    public bool IsNight()
    {
        return timeOfDay >= 0.65f || timeOfDay <= 0.2f;
    }
}
