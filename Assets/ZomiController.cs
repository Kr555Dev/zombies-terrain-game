using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomiController : MonoBehaviour
{
    // Start is called before the first frame update

    public float LookRadius = 10f;
    
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
