using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin_Pet : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator anim;
    public Vector3 petPos;
    public int petDelay;
    public Transform parent;
    public Queue<Vector3> parentPos;

    void Awake()
    {
        gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("petSkin") == 1)
            gameObject.SetActive(true);
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        parentPos = new Queue<Vector3>();
    }

    void Update()
    {
        Watch();
        Follow();

        if (Input.GetButton("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == 1;
        }

        if (Input.GetButton("Horizontal"))
            anim.SetBool("isPetWalking", true);
        else
            anim.SetBool("isPetWalking", false);
    }

    void Watch()
    {
        Vector3 temp = new Vector3(parent.position.x, parent.position.y - 0.5f, parent.position.z);
        //Input Pos
        if (!parentPos.Contains(parent.position))
            parentPos.Enqueue(temp);

        //Output Pos
        if (parentPos.Count > petDelay)
            petPos = parentPos.Dequeue();
       // else if (parentPos.Count < petDelay)
       //     petPos = parent.position;
    }

    void Follow()
    {
        transform.position = petPos;
    }
}
