using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyScriptNew : MonoBehaviour
{
    GameManagerCurrency CurrencyGM;
    public GameObject CoinParticle;   // Add Particle effect to currency.

    // Start is called before the first frame update
    void Start()
    {
        CurrencyGM = GameObject.Find("GameManagerCurrency").GetComponent<GameManagerCurrency> ();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            CurrencyGM.CurrencyAdd();
            Instantiate(CoinParticle, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
