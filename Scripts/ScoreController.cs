using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour {

    public GameObject cannon;
    CanonController canonScript;
    public Text score;

	void Start () {
        canonScript = cannon.GetComponent<CanonController>();
	}
	
	void Update () {
        score.text = canonScript.Score.ToString();
	}
}
