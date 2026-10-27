using UnityEngine;

public class CitySimulationManager : MonoBehaviour
{
    public DistrictManager districtManager;
    public FactionManager factionManager;
    public TimeOfDayManager timeOfDayManager;

    private void Awake()
    {
        districtManager = FindObjectOfType<DistrictManager>();
        factionManager = FindObjectOfType<FactionManager>();
        timeOfDayManager = FindObjectOfType<TimeOfDayManager>();
    }

    private void Update()
    {
        if (timeOfDayManager != null)
        {
            timeOfDayManager.UpdateTime();
        }

        if (districtManager != null)
        {
            DistrictState district = districtManager.GetDistrict("District_01");
            if (district != null)
            {
                float nightBoost = timeOfDayManager != null && timeOfDayManager.IsNight() ? 0.4f : 0f;
                district.crimeLevel = Mathf.Clamp(district.crimeLevel + (nightBoost * Time.deltaTime), 0f, 100f);
            }
        }
    }
}
