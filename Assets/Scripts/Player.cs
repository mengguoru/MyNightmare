using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
    public float speed = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float hori = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;
        Debug.Log(hori);
        float veri = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(hori, 0, veri);
    }
}
