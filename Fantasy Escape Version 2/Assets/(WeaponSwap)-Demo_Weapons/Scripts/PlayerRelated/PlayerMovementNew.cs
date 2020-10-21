using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovementNew : MonoBehaviour
{
    public CharacterController2DNew controller;
    public Animator animator;
    Rigidbody2D rb;
    float HorizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    IEnumerator dashCoroutine;

    bool isDashing;
    bool canDash = true;
    float direction = 1;
    float normalGravity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // get the component for rb
        normalGravity = rb.gravityScale; // set the gravity to normal
        
    }


    // Update is called once per frame
    void Update()
    {
        if (HorizontalMove != 0)
        {
            direction = HorizontalMove;
        }
       HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetKeyDown(KeyCode.K) && canDash == true)
        {
            if (dashCoroutine != null)
            {
                StopCoroutine(dashCoroutine);
            }
            dashCoroutine = Dash(.1f, 2);
            StartCoroutine(dashCoroutine);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "coin")
        {
            //CurrencyGM.CurrencyAdd();
            //Instantiate(CoinParticle, other.transform.position, Quaternion.identity);
            //Destroy(other.gameObject);
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }    

    private void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        if(isDashing)
        {
            rb.AddForce(new Vector2(direction * 1,0), ForceMode2D.Impulse);
        }
    }

    IEnumerator Dash (float dashDuration, float dashCooldown)
    {
        Vector2 orignalVelocity = rb.velocity;
        isDashing = true;
        canDash = false;
        rb.gravityScale = 0;
        rb.velocity = Vector2.zero;
        yield return new WaitForSeconds(dashDuration);
        isDashing = false;
        rb.gravityScale = normalGravity;
        rb.velocity = orignalVelocity;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }
}
