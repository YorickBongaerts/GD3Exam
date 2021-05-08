using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    [SerializeField] public MaterialsManager matManager;
    [SerializeField] public PlayerMove player;
    private void Start()
    {
        matManager = FindObjectOfType<MaterialsManager>();
        player = FindObjectOfType<PlayerMove>();
    }
    public virtual void ApplyExtraPower()
    {

    }
    public virtual void UnApplyExtraPower()
    {

    }
    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player.gameObject)
        {
            matManager.SwapToObject = gameObject;
            matManager.SwapToMaterial = this.gameObject.GetComponent<MeshRenderer>().material;
            matManager.ShouldSwap = true;
            ApplyExtraPower();
            gameObject.SetActive(false);
        }
    }
}
