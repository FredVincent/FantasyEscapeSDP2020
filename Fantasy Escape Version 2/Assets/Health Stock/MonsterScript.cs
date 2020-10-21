using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameControlScript.health -= 1;
    }
}
