using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rankingList : MonoBehaviour {
    public Text txt1;
    public Text txt2;
    public Text txt3;
    // Use this for initialization
    void Start () {
        txt1.text += secondsMyFormat(PlayerPrefs.GetFloat("first"));
        txt2.text += secondsMyFormat(PlayerPrefs.GetFloat("second"));
        txt3.text += secondsMyFormat(PlayerPrefs.GetFloat("third"));
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void returnMain()
    {
        SceneManager.LoadScene("Start");
    }

    string secondsMyFormat(float s)
    {
        float minutes = Mathf.Floor(s / 60);
        float seconds = Mathf.Floor(s % 60);

        return minutes + "分" + seconds + "秒";
    }
}
