using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePowerupScript : PowerUpBase
{
    public override void ApplyExtraPower()
    {
        matManager.MaxBlueTime += 1;
        matManager.CanUseBlue = true;
    }
    public override void UnApplyExtraPower()
    {
        matManager.MaxBlueTime -= 1;
        Destroy(gameObject);
    }
}
