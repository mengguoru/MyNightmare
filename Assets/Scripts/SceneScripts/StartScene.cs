using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {
    void startGame()
    {
        SceneManager.LoadScene("main");
    }
    void showRank()
    {
        SceneManager.LoadScene("rankingList");
    }
}
