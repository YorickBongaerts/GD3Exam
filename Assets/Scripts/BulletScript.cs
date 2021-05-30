using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float _bulletSpeed = 2f;
    private float _timer;
    private ObjectPooler2 pool;
    // Update is called once per frame
    private void Awake()
    {
        if (pool == null)
        {
            pool = FindObjectOfType<ObjectPooler2>();
        }
    }
    void FixedUpdate()
    {
        this.gameObject.transform.position += gameObject.transform.up * _bulletSpeed;
        _timer += Time.deltaTime;
        if (_timer >= 2f / _bulletSpeed)
        {
            _timer = 0;
            pool.ReturnBullet(gameObject);
            //this.gameObject.transform.position = Vector3.zero;
            //gameObject.SetActive(false);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.GetComponent<BaseEnemyBehaviour>())
    //    {
    //        other.lives--;
    //        if (other.gameObject.GetComponent<MeshRenderer>().material.name == gameObject.GetComponent<MeshRenderer>().material.name)
    //        {
    //            other.lives--;
    //        }
    //        Destroy(gameObject);
    //    }
    //}
}
