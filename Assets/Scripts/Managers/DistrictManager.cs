using System.Collections.Generic;
using UnityEngine;

public class DistrictManager : MonoBehaviour
{
    public Dictionary<string, DistrictState> districts = new Dictionary<string, DistrictState>();

    private void Awake()
    {
        RegisterDistrict(new DistrictState
        {
            districtId = "District_01",
            districtName = "Market Ward",
            crimeLevel = 35f,
            policePressure = 30f,
            factionInfluence = 40f,
            marketValue = 1.0f,
            risk = 0.25f
        });
    }

    public void RegisterDistrict(DistrictState district)
    {
        if (!districts.ContainsKey(district.districtId))
        {
            districts[district.districtId] = district;
        }
    }

    public DistrictState GetDistrict(string districtId)
    {
        if (districts.ContainsKey(districtId))
        {
            return districts[districtId];
        }

        return null;
    }

    public void UpdateDistrict(string districtId, float crimeDelta, float policeDelta, float factionDelta)
    {
        if (!districts.ContainsKey(districtId))
            return;

        DistrictState district = districts[districtId];
        district.crimeLevel = Mathf.Clamp(district.crimeLevel + crimeDelta, 0f, 100f);
        district.policePressure = Mathf.Clamp(district.policePressure + policeDelta, 0f, 100f);
        district.factionInfluence = Mathf.Clamp(district.factionInfluence + factionDelta, 0f, 100f);
    }
}

[System.Serializable]
public class DistrictState
{
    public string districtId;
    public string districtName;
    public float crimeLevel;
    public float policePressure;
    public float factionInfluence;
    public float marketValue;
    public float risk;
    public bool districtOpen = true;
    public List<string> activeFactions = new List<string>();
}
