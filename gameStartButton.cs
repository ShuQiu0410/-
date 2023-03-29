using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameStartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject title;
    bool  gameOver = false;
    public static bool ckeck = false;
    void Start()
    {
        this.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        { 
            move.gameStart = false;
            score.life = 10;
            title.SetActive(false);
            SceneManager.LoadScene(0);
        }
    }
    public void OnClick()
    {
        move.gameStart = true;
        this.gameObject.SetActive(false);
        score.gameOver=false;
        score.life = 10;
        score.ScorePoint = 0;
        ckeck = true;
    }
    
}
