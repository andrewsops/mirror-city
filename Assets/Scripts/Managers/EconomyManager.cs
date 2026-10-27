using System.Collections.Generic;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public float cash;
    public float debt;
    public float rentDue;
    public float foodCost;
    public float transportCost;
    public float emergencyFund;

    public List<string> recurringExpenses = new List<string> { "Rent", "Food", "Transport" };

    public void AddCash(float amount)
    {
        cash += amount;
        if (cash < 0f)
        {
            debt += Mathf.Abs(cash);
            cash = 0f;
        }
    }

    public void Spend(float amount)
    {
        cash -= amount;
        if (cash < 0f)
        {
            debt += Mathf.Abs(cash);
            cash = 0f;
        }
    }

    public void PayRent()
    {
        if (cash >= rentDue)
        {
            Spend(rentDue);
            Debug.Log("Rent paid.");
        }
        else
        {
            debt += rentDue - cash;
            cash = 0f;
            Debug.Log("Rent remains unpaid; debt increased.");
        }
    }
}
