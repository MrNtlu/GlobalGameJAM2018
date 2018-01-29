using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitterCollector : MonoBehaviour {

    private GameObject[] Transmitter;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Transmitter")
        {
            Transmitter = GameObject.FindGameObjectsWithTag("Transmitter");
            if (Transmitter.Length > 21)
            {
                Transmitter[3].SetActive(false);
                Transmitter[4].SetActive(false);
                Transmitter[5].SetActive(false);
            }
        }



    }
    void Update () {
    }
}
