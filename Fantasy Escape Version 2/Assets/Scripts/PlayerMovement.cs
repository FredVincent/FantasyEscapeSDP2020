using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
    float curTime;                  //For Attack
    public float coolTime = 0.5f;   //For Attack
    public Transform pos;           //For Attack
    public Vector2 boxSize;         //For Attack
    bool bow = false;

    // Update is called once per frame
    void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        //Attack
        if (curTime <= 0)
        {
            //Attack with 'J' key
            if (Input.GetKey(KeyCode.J))
            {
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position, boxSize, 0);
                foreach (Collider2D collider in collider2Ds)
                {
                    if (collider.tag == "Enemy")
                    {
                        OnAttack(collider.transform);
                    }
                }
                animator.SetTrigger("attack");
                curTime = coolTime;
            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }
    }

    //Debugging Attack Range.
    /*
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue; //Blue Box on Screen
        Gizmos.DrawWireCube(pos.position, boxSize);
    }
    */

    void OnAttack(Transform enemy)
    {
        Debug.Log("Attak Success!");
        // Score Up
        //gameManager.score += 10;

        // Enemy Die
        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
        enemyMovement.OnDamaged();
    }

    public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
