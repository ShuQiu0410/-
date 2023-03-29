using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawn;
    public GameObject tree;
    public GameObject borad;
    public GameObject cam;
    private Vector3 spawnPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        spawnPos = new Vector3(0,0,other.transform.position.z+ 130);
        Instantiate(spawn,spawnPos,transform.rotation);
        int i = Random.Range(3,7);
        while (i > 0)
        {
            float random = Random.Range(0.0f,1.0f);
            if(random < 0.7f)
            {
                Instantiate(tree,new Vector3(Random.Range(-9, 9), 4 , Random.Range(transform.position.z+70, transform.position.z + 180)), transform.rotation);
            }else if(random < 1.0f)
            {
                Instantiate(borad, new Vector3(Random.Range(-9, 9), -1.5f, Random.Range(transform.position.z+70, transform.position.z + 180)), transform.rotation);
            }
            i--;
        }
    }

}
