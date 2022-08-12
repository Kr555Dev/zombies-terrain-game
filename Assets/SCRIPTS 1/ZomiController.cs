using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZomiController : MonoBehaviour
{
    // Start is called before the first frame update

    public float LookRadius = 10f;
    public NavMeshAgent agent;

    Transform targetPlayer;
    void Start()
    {
        targetPlayer = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(targetPlayer.position, transform.position);

        if(distance <= LookRadius)
        {
            agent.SetDestination(targetPlayer.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
