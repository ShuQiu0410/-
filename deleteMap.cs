using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class deleteMap : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z - cam.transform.position.z < -50)
        {
            Destroy(gameObject);
        }
    }    
}
