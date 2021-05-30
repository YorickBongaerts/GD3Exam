using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler2 : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField]
    public Queue<GameObject> BulletPool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 200;

    public List<GameObject> ShootingBullet = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject bullet = Instantiate(BulletPrefab);
            BulletPool.Enqueue(bullet);
            bullet.SetActive(false);
        }
    }

    public GameObject GetBullet()
    {
        if (BulletPool.Count>0)
        {
            GameObject bullet = BulletPool.Dequeue();
            bullet.SetActive(true);
            ShootingBullet.Add(bullet);
            return bullet;
        }
        else
        {
            GameObject bullet = Instantiate(BulletPrefab);
            ShootingBullet.Add(bullet);
            return bullet;
        }
    }

    public void ReturnBullet(GameObject bullet)
    {
        ShootingBullet.Remove(bullet);
        BulletPool.Enqueue(bullet);
        bullet.SetActive(false);
    }
}
