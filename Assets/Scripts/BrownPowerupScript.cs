using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownPowerupScript : PowerUpBase
{
    [SerializeField] private GameObject Cube;
    public override void ApplyExtraPower()
    {
        Instantiate(Cube, new Vector3(player.gameObject.transform.position.x,1, player.gameObject.transform.position.z), Quaternion.identity);
        matManager.BrownUses--;
    }
    public override void UnApplyExtraPower()
    {
        Destroy(gameObject);
    }
    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player.gameObject)
        {
            matManager.SwapToObject = gameObject;
            matManager.SwapToMaterial = this.gameObject.GetComponent<MeshRenderer>().material;
            matManager.ShouldSwap = true;
            matManager.BrownUses++;
            Time.timeScale = 0;
            gameObject.SetActive(false);
        }
    }
}
