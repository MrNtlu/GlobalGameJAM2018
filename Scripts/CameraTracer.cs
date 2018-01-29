using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracer : MonoBehaviour {

    CanonController canoncontroller;
    public Transform player;
    public Vector3 offset;
    public GameObject canon;

    private void Start()
    {
        canoncontroller = canon.GetComponent<CanonController>();
    }
    void Update()
    {

    }
}
