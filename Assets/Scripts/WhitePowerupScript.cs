using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePowerupScript : PowerUpBase
{
    public override void ApplyExtraPower()
    {
        Debug.Log("white");
    }
    public override void UnApplyExtraPower()
    {
        GravityManager.ResetGravity();
        Debug.Log("RESET");
        player.LoweredGravity = false;
        Destroy(gameObject);
    }
}
