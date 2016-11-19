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

    float affectTimer;
    float speed2 = 4f;
    float speed0;

    // Use this for initialization
    void Start() {
        health = 100;
        healthTxt.text = "" + health;
        electricity = 100;
        elecTxt.text = ""+electricity;

        affectTimer = 5.1f;
        speed0 = speed;
    }

    // Update is called once per frame
    void Update() {
        affectTimer += Time.deltaTime;
        if (affectTimer < 5f)
            speed = speed2;
        else
            speed = speed0;

        float hori = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;
        //Debug.Log(hori);
        float veri = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(hori, 0, veri);

        //for fieldOfView script
        //transform.LookAt(new Vector3(hori, 0, veri)+ Vector3.up * transform.position.y);
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
        //Debug.Log("elec:"+electricity);
        elecTxt.text = "" + electricity;
        if (electricity > 0 && affectTimer > 5f)
        {
            affectTimer = 0f;
            electricity -= 5;
        }
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
