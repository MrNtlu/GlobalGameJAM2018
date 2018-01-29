using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour {

    public Rigidbody2D playerRigidbody;
    public Transform playerTransform;
    public float zRotate;
    public float upForce;
    public GameObject playerSub;
    public AudioSource SendMessage;
    public bool pressed;

    void Start () {
        pressed = false;
	}
	

	void Update () {

        if (Input.GetKey("a"))
        {
            zRotate = (zRotate + 3f);
            playerTransform.eulerAngles=new Vector3(0,0,zRotate);
            if (zRotate >= 90f)
                zRotate = 90f;
        }
        if (Input.GetKey("d"))
        {
            zRotate = (zRotate - 3f);
            playerTransform.eulerAngles = new Vector3(0, 0, zRotate);
            if (zRotate <= -90f)
                zRotate = -90f;
        }
        if (Input.GetKeyDown("space") && pressed==false)
        {
            SendMessage.Play();
            pressed = true;
            playerSub.SetActive(true);
            playerRigidbody.AddForce(playerTransform.up * upForce);
        }
    }

}
