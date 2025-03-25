using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContainer : MonoBehaviour
{
    public SimpleIntData scoreData;

    public void IncreaseScore(int amount)
    {
        scoreData.UpdateValue(amount);
    }
}
