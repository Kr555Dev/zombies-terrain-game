
using UnityEngine;

public class targetScript : MonoBehaviour
{
    public float health= 30f;
    //public float moveSpeed = 10f;
    //public GameObject player;

    void Update()
    {
       // transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            dieZomi();
        }
    }
    void dieZomi()
    {
        Destroy(gameObject);
    }
}