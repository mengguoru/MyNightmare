using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    public GameObject target;
    float targetLeft, targetRight, targetTop, targetDown;
    public GameObject monster;

    // Use this for initialization
    void Start () {
        //Debug.Log(target.transform.position);
        //Debug.Log(target.GetComponent<Renderer>().bounds.extents);
        targetLeft = target.transform.position.x - target.GetComponent<Renderer>().bounds.extents.x;
        targetRight = target.transform.position.x + target.GetComponent<Renderer>().bounds.extents.x;
        //Debug.Log(targetRight);
        targetTop = target.transform.position.z + target.GetComponent<Renderer>().bounds.extents.z;
        targetDown = target.transform.position.z - target.GetComponent<Renderer>().bounds.extents.z;
        //Debug.Log(targetDown);

        monster = Resources.Load("Prefabs/Monster", typeof(GameObject)) as GameObject;
        InstantiateRandomPosition(monster, 1, 1f);
    }

    public void InstantiateRandomPosition(GameObject theOrgin,int mount,float addHeight)
    {
        float randomPosX, randomPosZ,randomPosY;
        float height = 0;
        Vector3 randomPos;
        
        for(int i=0;i<mount;++i)
        {
            randomPosX = Random.Range(targetLeft, targetRight);
            randomPosZ = Random.Range(targetTop, targetDown);
            RaycastHit hit;
            if (Physics.Raycast(new Vector3(randomPosX, float.MinValue, randomPosZ), Vector3.down, out hit,Mathf.Infinity,target.layer))
            {
                height = hit.point.y;
            }
            randomPosY = height + addHeight;

            randomPos = new Vector3(randomPosX, randomPosY, randomPosZ);
            Instantiate(theOrgin, randomPos, Quaternion.identity);
        }
    }
}
