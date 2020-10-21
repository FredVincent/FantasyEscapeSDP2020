using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerCurrency : MonoBehaviour
{
    public int Currency;
    public Text cointext;
    
    // Start is called before the first frame update
    void Start()
    {
        cointext = GameObject.Find("CoinAmount").GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        cointext.text = " " + Currency;
    }

    public void CurrencyAdd()
    {
        Currency += 1;
    }
}
