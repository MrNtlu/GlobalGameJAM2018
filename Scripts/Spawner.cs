using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour {

    public Transform player,cannon;
    public Rigidbody2D playerrb;
    public GameObject arrow;
    public TrailRenderer playertrail;
    public GameObject playerSub;
    KalanCanController kalancanScript;
    public GameObject kalanCanText;
    public GameObject gameoverUI;
    public AudioSource gameoveraudio;
    MobileController mobileScript;
    public GameObject spaceButton;

    void Start () {
        kalancanScript = kalanCanText.GetComponent<KalanCanController>();
        mobileScript = spaceButton.GetComponent<MobileController>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            mobileScript.pressed = false;
            kalancanScript.kalancan = kalancanScript.kalancan - 1;
            playerSub.SetActive(false);
            player.position = new Vector3(cannon.position.x,cannon.position.y,cannon.position.z);
            playerrb.velocity = Vector3.zero;
            playertrail.Clear();
            if (kalancanScript.kalancan <= 0)
            {
                gameoveraudio.Play();
                Time.timeScale = 0f;
                gameoverUI.SetActive(true);
            }
        }



    }

    
}
