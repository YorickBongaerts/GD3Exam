using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    [SerializeField] private MaterialsManager matManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            matManager.SwapToMaterial = this.gameObject.GetComponent<MeshRenderer>().material;
            matManager.ShouldSwap = true;
            Destroy(this.gameObject);
        }
    }
}
