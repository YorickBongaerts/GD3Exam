using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float _bulletSpeed = 2f;
    private float _timer;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.position += gameObject.transform.up * _bulletSpeed;
        _timer += Time.deltaTime;
        if (_timer >= 2f / _bulletSpeed)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BaseEnemyBehaviour>())
        {
            other.lives--;
            if (other.gameObject.GetComponent<MeshRenderer>().material.name == gameObject.GetComponent<MeshRenderer>().material.name)
            {
                other.lives--;
            }
            Destroy(gameObject);
        }
    }
}
