using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWeapon : MonoBehaviour
{
    public int NumberSwap; // Swapping for each weapon. (1 = sword. 2 = bow and 3 = orb.)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D WeaponSwap)
    {
        PlayerCombatNew Swap = WeaponSwap.GetComponent<PlayerCombatNew>();
        if (Swap != null)
        {
            Swap.attackMode = NumberSwap; // Swap the attackmode to the numberswap.
        }
        Destroy(gameObject);
    }
}
