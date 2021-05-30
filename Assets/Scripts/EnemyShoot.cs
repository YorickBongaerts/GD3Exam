using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private GameObject player;
    private ObjectPooler2 pool;
    void Start()
    {
        pool = FindObjectOfType<ObjectPooler2>();
        player = FindObjectOfType<PlayerMove>().gameObject;
        InvokeRepeating("Shoot", 1f, 1f);
    }
    void Shoot()
    {
        GameObject bullet = pool.GetBullet();
        bullet.transform.position = gameObject.transform.position;
        bullet.transform.rotation = Quaternion.Euler(90, gameObject.transform.rotation.eulerAngles.y, 0);
        //var go = ObjectPooler.Instance.SpawnFromPool("Bullets", gameObject.transform.position, Quaternion.Euler(90,gameObject.transform.rotation.eulerAngles.y,0));
    }
}
