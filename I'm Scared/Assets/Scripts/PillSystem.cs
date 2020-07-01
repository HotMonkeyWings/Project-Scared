using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PillSystem : MonoBehaviour
{
    public int Pill_No = 0;
    [SerializeField]
    Text pillDisplay;

    private void Start()
    {
        pillDisplay.text = "Pills : " + Pill_No;
    }

    public void addPill(int increase)
    {
        Pill_No+=increase;
        pillDisplay.text = "Pills : " + Pill_No;
    }

    public void reducePill()
    {
        if (Pill_No > 0)
        {
            Pill_No--;
            pillDisplay.text = "Pills : " + Pill_No;
        }
    }
}
