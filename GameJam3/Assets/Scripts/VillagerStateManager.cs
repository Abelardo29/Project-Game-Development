﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerStateManager : MonoBehaviour {

    public GameObject target;
    public GameObject home;
    public string state;

    private Rigidbody rb;
    public int iron;
    public int stone;
    public int wheat;
    public int wood;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        switch (state)
        {
            case "TravelTarget":
                rb.MovePosition(target.transform.position);
                break;
            case "TravelHome":
                rb.MovePosition(home.transform.position);
                break;
            case "Harvesting":

                break;
            case "Storing":

                break;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Resource")
            state = "Harvesting";
        if (collision.gameObject.tag == "Building")
            state = "Storing";
    }

}
