﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


    public GameObject player;

    private Vector3 offset;

    //Use this for initialisation
	void Start () {
        offset = transform.position - player.transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	
	}
}
