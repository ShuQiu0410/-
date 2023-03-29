using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class life : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStartButton.ckeck = true){
            
            this.transform.position = new Vector3 (1265,460,0);
            GetComponent<Text>().fontSize = 15 ;
            GetComponent<Text>().text = " = " + score.life;
            if(score.life <= 0)
            {
                GetComponent<Text>().text = "  ";
                move.gameStart = false;
                gameStartButton.ckeck = false;
            }
        }
        
        
    }
}
