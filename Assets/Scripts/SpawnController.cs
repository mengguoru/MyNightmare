﻿using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    public GameObject target;
    float targetLeft, targetRight, targetTop, targetDown;
    public GameObject monster;

    float monsterDelay = 3f;
    float timer;

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
        GameObject obstacle1 = Resources.Load("Prefabs/rock", typeof(GameObject)) as GameObject;
        InstantiateRandomPosition(obstacle1, 10, 0f);
        GameObject obstacle2 = Resources.Load("Prefabs/tree", typeof(GameObject)) as GameObject;
        InstantiateRandomPosition(obstacle2, 7, 0f);

        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>monsterDelay)
        {
            InstantiateRandomPosition(monster, 1, 1f);
            timer = 0;
        }

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
