using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(PlayerPrefs.GetFloat("currentLive"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
