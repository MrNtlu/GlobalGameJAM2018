using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntenController : MonoBehaviour {

    zRotateController zRotate;
    public GameObject zRotateControllerObj;
    public Transform antenna;

	void Start () {
        zRotate = zRotateControllerObj.GetComponent<zRotateController>();
        
	}
	
	void Update () {
        antenna.eulerAngles = new Vector3(0f, 0f, zRotate.zRotate);
	}
}
