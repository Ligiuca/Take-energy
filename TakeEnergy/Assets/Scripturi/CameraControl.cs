using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject UFO;

    public Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position - UFO.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = UFO.transform.position + offset;
	}
}
