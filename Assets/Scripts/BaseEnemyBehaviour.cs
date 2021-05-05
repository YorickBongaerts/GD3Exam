using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseEnemyBehaviour : MonoBehaviour
{
    public int HP;
    private NavMeshAgent agent;
    private EnemySpawnerScript spawner;
    public GameObject[] PowerUps = new GameObject[4];
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerMove>().gameObject;
        spawner = FindObjectOfType<EnemySpawnerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);

        if (HP <= 0)
        {
            spawner.amountOfEnemies--;
            if (UnityEngine.Random.Range(0, 10) == 0)
            {
                Instantiate(PowerUps[UnityEngine.Random.Range(0, 4)], this.gameObject.transform.position, this.gameObject.transform.rotation);
            }
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ObjectPooler.Instance.poolDictionary["Bullets"].Contains(other.gameObject))
        {
            HP--;
            if (other.GetComponent<MeshRenderer>().material.name == gameObject.GetComponent<MeshRenderer>().material.name)
            {
                HP--;
            }
        }
    }
}
