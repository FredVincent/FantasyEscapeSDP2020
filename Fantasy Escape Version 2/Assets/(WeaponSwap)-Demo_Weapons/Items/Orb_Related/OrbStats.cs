using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbStats : MonoBehaviour
{
    public float OrbSpeed = 20f;
    public int OrbDamage;
    public Rigidbody2D OrbRB;
    public GameObject OrbEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        OrbRB.velocity = transform.right * OrbSpeed;
    }

    void OnTriggerEnter2D (Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(OrbDamage);
        }
        Instantiate(OrbEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
