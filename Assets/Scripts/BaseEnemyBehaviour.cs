using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class BaseEnemyBehaviour : MonoBehaviour
{
    public int HP;
    private NavMeshAgent agent;
    private EnemySpawnerScript spawner;
    public GameObject[] PowerUps = new GameObject[4];
    [SerializeField] private GameObject player;
    private GameObject overlayPanel;
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerMove>().gameObject;
        spawner = FindObjectOfType<EnemySpawnerScript>();
        overlayPanel = FindObjectOfType<GameCanvas>().transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.SetDestination(player.transform.position);

        if (HP <= 0)
        {
            spawner.amountOfEnemies--;
            if (UnityEngine.Random.Range(0, 10) == 0)
            {
                Instantiate(PowerUps[UnityEngine.Random.Range(0, 4)], this.gameObject.transform.position, this.gameObject.transform.rotation);
            }
            ScoreSystem.AddPoints(gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material);
            ScoreSystem.UpdateUI(overlayPanel.transform.GetChild(0).GetComponent<Text>());
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ObjectPooler.Instance.poolDictionary["Bullets"].Contains(other.gameObject))
        {
            HP--;
            if (other.GetComponent<MeshRenderer>().material.name == gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.name)
            {
                HP--;
            }
        }
        if (other.gameObject == player.gameObject)
        {
            player.GetComponent<PlayerMove>().HP--;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9)
        {
            agent.speed = 0;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 9)
        {
            agent.speed = 3.5f;
        }
    }
}
