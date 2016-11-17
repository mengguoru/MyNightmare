using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (health <= 0)
            SceneManager.LoadScene("End");
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
        if(100 == health)
        {

        }else if(health < 100)
        {
            electricity -= 30;
            health += 10;
            if (health > 100)
                health = 100;
        }
        elecTxt.text = "" + electricity;
        healthTxt.text = "" + health;
    }
}
