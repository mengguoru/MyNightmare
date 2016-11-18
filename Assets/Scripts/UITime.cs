using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITime : MonoBehaviour {
    public float timer;
    public Text timeTxt;

	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        showTime();
	}

    void OnDestroy()
    {
        PlayerPrefs.SetFloat("currentLive", timer);
    }

    void showTime()
    {
        float minutes = Mathf.Floor(timer / 60);
        float seconds = Mathf.Floor(timer % 60);
        timeTxt.text = "Time " + minutes + ":" + seconds;
    }
}
