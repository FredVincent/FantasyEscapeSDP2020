using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator animator;
    SpriteRenderer spriteRenderer;
    BoxCollider2D box_en; //If The Enemy use other Collider2D such as BoxCollider2D, Change the data type.

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        box_en = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        
    }

    public void OnDamaged() //For Enemy Die
    {
        //Death Animation
        animator.SetTrigger("death");
        //Sprite Alpha
        //spriteRenderer.color = new Color(1, 1, 1, 0.4f);
        //Sprite Filp Y
        //spriteRenderer.flipY = true;
        //Collider Diable
        box_en.enabled = false;
        //Die Effect Jump
        //rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        //Destroy
        Invoke("DeActive", 1);
    }

    void DeActive()
    {
        gameObject.SetActive(false);
    }
}
