
using UnityEngine;

public class targetScript : MonoBehaviour
{
    public float health= 30f;
    //public float moveSpeed = 10f;
    //public GameObject player;
    //public ParticleSystem boomEffect;
    //private Animation anim;
    //public GameObject boomEffect;
    private void Start()
    {
        //anim = GetComponent<Animation>();
    }
    

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
            //boomEffect.Play();
        }
    }
    void dieZomi()
    {
        //boomEffect.Play();
        //anim.Play("Z_FallingBack");
        //Instantiate(boomEffect, transform.position, Quaternion.identity);
        
        Destroy(gameObject);

    }
}