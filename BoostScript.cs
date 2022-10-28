using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public bool canBoost;
    private GameObject player;
    private Vector3 offset;
    public float boostOffset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(10 + boostOffset, 8.5f, 0);
        transform.position = player.transform.position + offset;
        if (playerControllerScript.boosting == true && canBoost)
        {
            boostOffset = boostOffset + 0.05f;
        }
        if (playerControllerScript.slowing)
        {
            boostOffset = boostOffset - 0.1f;
        }
        if(boostOffset >= 6.5f)
        {
            boostOffset = 6.5f;
            canBoost = false;
        }
        if(boostOffset < 6.5f)
        {
            canBoost = true;
        }
        if(boostOffset <= 0.5)
        {
            boostOffset = 0.5f;
        }
    }
}
