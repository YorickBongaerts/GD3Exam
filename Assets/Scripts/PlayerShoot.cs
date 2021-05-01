using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private MaterialsManager matManager;
    [SerializeField] private GameObject Bullet;
    public void OnShoot(InputAction.CallbackContext context)
    {
        Shoot();
    }
    void Shoot()
    {
        for (int i = 0; i <= 7; i++)
        {
            var go = GameObject.Instantiate(Bullet, this.gameObject.transform.position + gameObject.transform.forward, Quaternion.Euler(new Vector3(90, i * 45, 0)));
            go.GetComponent<MeshRenderer>().material = matManager._bulletMaterials[i];
        }
    }
}
