using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    public Text cashLabel;
    public Text heatLabel;
    public Text districtLabel;
    public Text timeLabel;
    public Text objectiveLabel;

    public void UpdateHUD(PlayerState state, DistrictManager districtManager, TimeOfDayManager timeOfDayManager, JobManager jobManager)
    {
        if (state == null)
            return;

        if (cashLabel != null)
            cashLabel.text = "Cash: $" + state.cash.ToString("0");

        if (heatLabel != null)
            heatLabel.text = "Heat: " + state.heat.ToString("0.0");

        if (districtLabel != null)
            districtLabel.text = "District: " + state.currentDistrictId;

        if (timeLabel != null && timeOfDayManager != null)
            timeLabel.text = "Time: " + timeOfDayManager.GetTimeLabel();

        if (objectiveLabel != null)
        {
            JobDefinition job = jobManager != null ? jobManager.GetAvailableJob(state.currentDistrictId) : null;
            objectiveLabel.text = job != null ? job.description : "No active job.";
        }
    }
}
