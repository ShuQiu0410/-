using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class MaxPrint : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            this.transform.position = new Vector3 (170,450,0);
            GetComponent<Text>().fontSize = 15 ;
            GetComponent<Text>().text ="max score : " + score.max ;
            if(score.life <= 0)
            {
                GetComponent<Text>().text = "  ";
            }
        
        
    }
}