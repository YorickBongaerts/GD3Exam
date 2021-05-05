using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    [SerializeField] private MaterialsManager matManager;
    [SerializeField] private GameObject player;
    private void Start()
    {
        matManager = FindObjectOfType<MaterialsManager>();
        player = FindObjectOfType<PlayerMove>().gameObject;
    }
    public virtual void ApplyExtraPower()
    {

    }
    public virtual void UnApplyExtraPower()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            matManager.SwapToObject = gameObject;
            matManager.SwapToMaterial = this.gameObject.GetComponent<MeshRenderer>().material;
            matManager.ShouldSwap = true;
            ApplyExtraPower();
            gameObject.SetActive(false);
        }
    }
}
