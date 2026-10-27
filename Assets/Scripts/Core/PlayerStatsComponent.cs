using UnityEngine;

public class PlayerStatsComponent : MonoBehaviour
{
    public PlayerState state;

    private void Awake()
    {
        state = new PlayerState();
    }

    public void ModifyHealth(float delta)
    {
        state.health = Mathf.Clamp(state.health + delta, 0f, 100f);
    }

    public void ModifyStress(float delta)
    {
        state.stress = Mathf.Clamp(state.stress + delta, 0f, 100f);
    }

    public void ModifyHeat(float delta)
    {
        state.heat = Mathf.Clamp(state.heat + delta, 0f, 100f);
    }
}
