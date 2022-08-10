using UnityEngine;

public class gun : MonoBehaviour 
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpscam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public float ForceOnHit;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }
    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            muzzleFlash.Play();
            Debug.Log(hit.transform.name);

            targetScript target = hit.transform.GetComponent<targetScript>();
            
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * ForceOnHit * Time.deltaTime);
            }
            
            GameObject impactGo =Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo, 2f); 
        }

    }
}
