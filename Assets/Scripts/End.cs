using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {
    public Text show;
	// Use this for initialization
	void Start () {
        //Debug.Log(PlayerPrefs.GetFloat("currentLive"));
        float currentScore = PlayerPrefs.GetFloat("currentLive");
        if (currentScore > PlayerPrefs.GetFloat("first"))
        {
            float tmp = PlayerPrefs.GetFloat("first");
            PlayerPrefs.SetFloat("first", currentScore);
            float tmp2 = PlayerPrefs.GetFloat("second");
            PlayerPrefs.SetFloat("second", tmp);
            PlayerPrefs.SetFloat("third", tmp2);
        }
        else if(currentScore > PlayerPrefs.GetFloat("second"))
        {
            float tmp2 = PlayerPrefs.GetFloat("second");
            PlayerPrefs.SetFloat("second", currentScore);
            PlayerPrefs.SetFloat("third", tmp2);
        }
        else if (currentScore > PlayerPrefs.GetFloat("third"))
            PlayerPrefs.SetFloat("third", currentScore);

        float minutes = Mathf.Floor(currentScore / 60);
        float seconds = Mathf.Floor(currentScore % 60);
        show.text += minutes + "分" + seconds + "秒";
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void returnMain()
    {
        SceneManager.LoadScene("Start");
    }
    void startGame()
    {
        SceneManager.LoadScene("main");
    }
}
