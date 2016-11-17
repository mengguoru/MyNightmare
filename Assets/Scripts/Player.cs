using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float speed = 0.2f;

    public Text healthTxt;
    float health;

	// Use this for initialization
	void Start () {
        health = 100;
        healthTxt.text = ""+health;
	}
	
	// Update is called once per frame
	void Update () {
        float hori = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;
        //Debug.Log(hori);
        float veri = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(hori, 0, veri);
    }

    void beAttacked()
    {
        Debug.Log("beAttacked");
        health -= 20;
        healthTxt.text = "" + health;
    }
}
