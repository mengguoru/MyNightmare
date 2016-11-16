using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

    public float speed;
    GameObject target;
    public float closestDis;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(target.transform.position, transform.position) > closestDis)
        {
            Vector3 offset = target.transform.position - transform.position;
            transform.Translate(offset.normalized *speed* Time.deltaTime);
        }
    }
}
