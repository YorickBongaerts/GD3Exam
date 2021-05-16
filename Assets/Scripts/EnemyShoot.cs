using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Start()
    {
        player = FindObjectOfType<PlayerMove>().gameObject;
        InvokeRepeating("Shoot", 1f, 1f);
    }
    void Shoot()
    {
        var go = ObjectPooler.Instance.SpawnFromPool("Bullets", gameObject.transform.position, Quaternion.Euler(90,gameObject.transform.rotation.eulerAngles.y,0));
    }
}
