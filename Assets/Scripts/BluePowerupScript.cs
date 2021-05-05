using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePowerupScript : PowerUpBase
{
    public override void ApplyExtraPower()
    {
        Debug.Log("blue");
    }
    public override void UnApplyExtraPower()
    {
        Debug.Log("blue gone");
    }
}
