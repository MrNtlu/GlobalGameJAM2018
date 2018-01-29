using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MobileController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Rigidbody2D playerRigidbody;
    public Transform playerTransform;
    public float zRotate;
    zRotateController zRotateVal;
    public float upForce;
    public GameObject playerSub,zRotateObject;
    public AudioSource SendMessage;
    public bool pressed;
    public bool left,right,space;

    void Start () {

        pressed = false;
        left = false;
        right = false;
        space = false;
        zRotateVal = zRotateObject.GetComponent<zRotateController>();
        zRotate = zRotateVal.zRotate;

    }

    void Update()
    {
        if (left)
        {
            zRotate = zRotateVal.zRotate;
            zRotate = (zRotate + 3f);
            playerTransform.eulerAngles = new Vector3(0, 0, zRotate);
            if (zRotate >= 90f)
                zRotate = 90f;
            zRotateVal.zRotate = zRotate;
        }
        if (right)
        {
            zRotate = zRotateVal.zRotate;
            zRotate = (zRotate - 3f);
            playerTransform.eulerAngles = new Vector3(0, 0, zRotate);
            if (zRotate <= -90f)
                zRotate = -90f;
            zRotateVal.zRotate= zRotate ;
        }
        if (space==true && pressed == false)
        {
            SendMessage.Play();
            pressed = true;
            playerSub.SetActive(true);
            playerRigidbody.AddForce(playerTransform.up * upForce);
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
        if(gameObject.name=="LeftButton")
            left = true;
        if (gameObject.name == "RightButton")
            right = true;
        if (gameObject.name == "SpaceButton")
            space = true;

    }

    public void OnPointerUp(PointerEventData data)
    {
        left = false;
        right = false;
        space = false;
    }

}
