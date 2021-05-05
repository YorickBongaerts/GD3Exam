using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPowerupScript : PowerUpBase
{
    public override void ApplyExtraPower()
    {
        FindObjectOfType<PlayerMove>()._moveSpeed *= 2;
        Debug.Log("red");
    }
    public override void UnApplyExtraPower()
    {
        FindObjectOfType<PlayerMove>()._moveSpeed /= 2;
        Debug.Log("red gone");
    }
}
