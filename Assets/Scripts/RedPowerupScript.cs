using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPowerupScript : PowerUpBase
{
    public override void ApplyExtraPower()
    {
        player._moveSpeed *= 2;
        Debug.Log("red");
    }
    public override void UnApplyExtraPower()
    {
        player._moveSpeed /= 2;
        Debug.Log("red gone");
        Destroy(gameObject);
    }
}
