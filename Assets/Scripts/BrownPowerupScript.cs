using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownPowerupScript : PowerUpBase
{
    public override void ApplyExtraPower()
    {
        Debug.Log("brown");
    }
    public override void UnApplyExtraPower()
    {
        Debug.Log("brown gone");
    }
}
