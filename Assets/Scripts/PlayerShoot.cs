using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private MaterialsManager matManager;
    [SerializeField] private GameObject Bullet;
    private SoundManager SoundManager;
    private ObjectPooler2 pool;
    public void OnShoot(InputAction.CallbackContext context)
    {
        pool = FindObjectOfType<ObjectPooler2>();
        this.gameObject.GetComponent<PlayerMove>().animator.Play("Shoot");
        SoundManager = FindObjectOfType<SoundManager>();
        Shoot();
    }
    void Shoot()
    {
        SoundManager.PlayShoot();
        for (int i = 0; i <= 7; i++)
        {
            GameObject bullet = pool.GetBullet();
            bullet.transform.position = gameObject.transform.position;
            bullet.transform.rotation = Quaternion.Euler(new Vector3(90, i * 45, 0));
            //var go = ObjectPooler.Instance.SpawnFromPool("Bullets", gameObject.transform.position, Quaternion.Euler(new Vector3(90, i * 45, 0)));
            bullet.GetComponent<MeshRenderer>().material = matManager._bulletMaterials[i];
        }
    }
}
