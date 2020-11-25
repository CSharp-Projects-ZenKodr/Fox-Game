using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float coin = 0;
    public TextMeshProUGUI textCoins;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Cherry")
        {
            Destroy(collision.gameObject);
            coin ++;
            textCoins.text = coin.ToString();
            
        }
        
    }
}
