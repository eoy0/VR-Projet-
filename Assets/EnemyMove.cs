using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    Transform player; 

    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(player.position);
    }
}
