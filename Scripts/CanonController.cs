using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour {
    
    public Transform player;
    public Rigidbody2D playerrb;
    public Transform camera;
    public GameObject arrow;
    public Transform cannon;
    public GameObject[] obstacles;
    public TrailRenderer playertrail;
    public GameObject playerSub;
    public int Score;
    KalanCanController kalancanScript;
    public GameObject kalanCanText;
    public AudioSource transmitted;

    zRotateController zRotateScript;

    MobileController mobileScript;
    public GameObject spaceButton,zRotateCont;

    void Start () {
        kalancanScript = kalanCanText.GetComponent<KalanCanController>();
        mobileScript = spaceButton.GetComponent<MobileController>();
        zRotateScript = zRotateCont.GetComponent<zRotateController>();

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.eulerAngles=new Vector3(0f, 0f, 0f);
            zRotateScript.zRotate = 0f;
            mobileScript.pressed = false;
            
            transmitted.Play();
            kalancanScript.kalancan = kalancanScript.kalancan + 2;
            if (kalancanScript.kalancan >= 15)
                kalancanScript.kalancan = 15;
            Score = Score + 1;
            playerSub.SetActive(false);
            //fakeArrow.SetActive(false); 
            camera.position = new Vector3(camera.position.x, camera.position.y + 9.5f,camera.position.z);
            player.position = new Vector3(cannon.position.x, cannon.position.y, cannon.position.z);
            playerrb.velocity = Vector3.zero;
            playertrail.Clear();

            Vector3 spawnPosition = new Vector3(Random.Range(player.position.x+1f,player.position.x-0.9f), Random.Range(player.position.y + 2f, player.position.y + 4.5f), player.position.z);
            Vector3 spawnPosition2 = new Vector3(Random.Range(player.position.x-1, player.position.x - 3f), Random.Range(player.position.y + 2f, player.position.y +4.5f), player.position.z);
            Instantiate(obstacles[0], spawnPosition, gameObject.transform.rotation);
            Instantiate(obstacles[1], spawnPosition2, gameObject.transform.rotation);
            if (spawnPosition.x==spawnPosition2.x || spawnPosition.x+2f==spawnPosition2.x || spawnPosition.x==spawnPosition2.x+2f)
            {
                spawnPosition.x = Random.Range(player.position.x + 1f, player.position.x - 3f);
                spawnPosition2.x = Random.Range(player.position.x + 1f, player.position.x - 3f);
            }
            if (Score >= 10)
            {
                Vector3 spawnPosition3 = new Vector3(Random.Range(player.position.x + 1f, player.position.x - 3f), Random.Range(player.position.y + 4.5f, player.position.y + 5.8f), player.position.z);

                Instantiate(obstacles[2], spawnPosition3, gameObject.transform.rotation);

            }
            
            /*if (spawnPosition.y == spawnPosition2.y || spawnPosition.y + 2f == spawnPosition2.y || spawnPosition.y == spawnPosition2.y + 2f)
            {
                spawnPosition.y = Random.Range(player.position.y + 3.8f, player.position.y - 3.8f);
                spawnPosition2.y = Random.Range(player.position.y + 3.8f, player.position.y - 3.8f);
            }*/

        }
        if (collision.gameObject.tag == "Transmitter")
        {
            
        }
    }



    void Update () {

    }
}
