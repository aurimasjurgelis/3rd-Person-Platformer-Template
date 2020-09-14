﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public int value;

    public GameObject pickupEffect;

    public string soundToPlay;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.instance.AddCoins(value);
            Destroy(gameObject);
            Instantiate(pickupEffect, transform.position,transform.rotation);
            AudioManager.instance.PlaySoundEffect(soundToPlay);
        }
    }
}
