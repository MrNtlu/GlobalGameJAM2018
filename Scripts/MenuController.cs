using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    KalanCanController kalancanScript;
    public GameObject kalanCanText;
    public GameObject cannon;
    CanonController canonScript;
    public GameObject gameoverUI;
    public AudioSource soundtrack;


    void Start () {
        kalancanScript = kalanCanText.GetComponent<KalanCanController>();
        canonScript = cannon.GetComponent<CanonController>();
        if (GameObject.FindGameObjectsWithTag("Music").Length >= 2)
        {
            GameObject[] musics = GameObject.FindGameObjectsWithTag("Music");
            GameObject.Destroy(musics[1]);

        }

    }

    public void Restart () {
        DontDestroyOnLoad(soundtrack);
        gameoverUI.SetActive(false);
        kalancanScript.kalancan = 5;
        canonScript.Score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");

	}
}
