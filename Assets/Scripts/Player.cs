using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float speed = 0.2f;

    public Text healthTxt;
    float health;
    float electricity;
    public Text elecTxt;

    // Use this for initialization
    void Start() {
        health = 100;
        healthTxt.text = "" + health;
        electricity = 100;
        elecTxt.text = ""+electricity;
    }

    // Update is called once per frame
    void Update() {
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

    void callSpeed()
    {
        electricity -= 5;
        //Debug.Log("elec:"+electricity);
        elecTxt.text = "" + electricity;
    }

    void callHealth()
    {
        electricity -= 30;
        elecTxt.text = "" + electricity;
    }
}
