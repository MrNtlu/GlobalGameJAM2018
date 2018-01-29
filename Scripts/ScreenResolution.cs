using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour {

	void Awake () {
		
        Screen.SetResolution(500,900,false);
 
	}
}
