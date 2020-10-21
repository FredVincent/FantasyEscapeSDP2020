using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowStats : MonoBehaviour
{
    public float speed = 30f;
    public int BowDamage;
    public Rigidbody2D rb;
    public GameObject BowImpactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(BowDamage);
        }

        Instantiate(BowImpactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
