using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private MaterialsManager matManager;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private SoundManager SoundManager;
    public void OnShoot(InputAction.CallbackContext context)
    {
        this.gameObject.GetComponent<PlayerMove>().animator.Play("Shoot");
        Shoot();
    }
    void Shoot()
    {
        SoundManager.PlayShoot();
        for (int i = 0; i <= 7; i++)
        {
            var go = ObjectPooler.Instance.SpawnFromPool("Bullets", gameObject.transform.position, Quaternion.Euler(new Vector3(90, i * 45, 0)));
            go.GetComponent<MeshRenderer>().material = matManager._bulletMaterials[i];
        }
    }
}
