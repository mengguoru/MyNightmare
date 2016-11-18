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
        txt1.text += PlayerPrefs.GetFloat("first");
        txt2.text += PlayerPrefs.GetFloat("second");
        txt3.text += PlayerPrefs.GetFloat("third");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void returnMain()
    {
        SceneManager.LoadScene("Start");
    }
}
