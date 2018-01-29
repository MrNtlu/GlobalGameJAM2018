using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KalanCanController : MonoBehaviour {

    public int kalancan = 5;
    public Text kalancanInt;


    void Update () {
        kalancanInt.text = kalancan.ToString();
    }
}
