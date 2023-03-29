using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlePrint : MonoBehaviour
{   
    public GameObject losetitle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score.life == 0){
            losetitle.SetActive(true);

        }
    }
}
