using UnityEngine;
using System.Collections.Generic;

public class DayNightCycle : MonoBehaviour
{
    [Header("Lighting")]
    public Light sunLight;
    public Gradient lightColor;
    public AnimationCurve intensityCurve;

    [Header("Timing")]
    public float cycleMinutes = 10f;
    public float currentTime = 0.25f;
    private float cycleDuration;

    private void Awake()
    {
        cycleDuration = cycleMinutes * 60f;

        if (sunLight == null)
        {
            sunLight = GetComponent<Light>();
        }
    }

    private void Update()
    {
        currentTime += Time.deltaTime / cycleDuration;
        if (currentTime >= 1f)
            currentTime = 0f;

        float adjusted = currentTime;
        float angle = adjusted * 360f - 90f;
        transform.rotation = Quaternion.Euler(angle, 30f, 0f);

        if (sunLight != null)
        {
            sunLight.color = lightColor.Evaluate(adjusted);
            sunLight.intensity = intensityCurve.Evaluate(adjusted);
        }
    }
}
