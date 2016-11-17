using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

    public float speed;
    GameObject target;
    public float closestDis;

    float attackDelay;
    float timer;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player");

        attackDelay = 2f;
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(target.transform.position, transform.position) > closestDis)
        {
            Vector3 offset = target.transform.position - transform.position;
            transform.Translate(offset.normalized *speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if(timer > attackDelay && Vector3.Distance(target.transform.position, transform.position) < 1.5f)
        {
            target.transform.gameObject.SendMessage("beAttacked");
            timer = 0;
        }
    }
}
