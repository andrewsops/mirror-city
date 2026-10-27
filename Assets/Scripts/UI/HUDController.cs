using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text moneyText;
    public Text heatText;
    public Text districtText;
    public Text cashText;

    public void Refresh(PlayerState state, DistrictManager districtManager, FactionManager factionManager)
    {
        if (state == null)
            return;

        if (moneyText != null)
            moneyText.text = "Cash: $" + state.cash.ToString("0");

        if (heatText != null)
            heatText.text = "Heat: " + state.heat.ToString("0.0");

        if (districtText != null)
            districtText.text = "District: " + state.currentDistrictId;

        if (cashText != null)
            cashText.text = "Debt: $" + state.debt.ToString("0");
    }
}
