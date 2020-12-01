﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;

    void Start()
    {
        text.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.tag == "Player")
        {
            text.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            text.SetActive(false);

        }
    }
}
