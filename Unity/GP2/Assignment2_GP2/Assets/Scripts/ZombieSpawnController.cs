using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieSpawnController : MonoBehaviour {

    public GameObject targeGO;
    public GameObject pill;
    private NavMeshAgent navMeshAgent;

    // Use this for initialization
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (targeGO != null)
        {
            if (pill == null)
            {
                navMeshAgent.SetDestination(-targeGO.transform.position);
            }
            else
            {
                navMeshAgent.SetDestination(targeGO.transform.position);
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (pill == null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }    
        }
    }
}
