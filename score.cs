using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int ScorePoint=0;
    public GameObject cam;
    public static int n=30;
    public static int life=10;
    public static   bool  gameOver = false;
    public GameObject player;
    public static float a=10.0f;
    public static int max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStartButton.ckeck = true){
        ScorePoint = ((int)cam.transform.position.z + 80) / 40;
        this.transform.position = new Vector3 (170,480,0);
        GetComponent<Text>().fontSize = 15;
        GetComponent<Text>().text = "SCORE = "+ ScorePoint;
        if(ScorePoint >= max){
            max = ScorePoint;
        }
        
        if(ScorePoint == 10){
            n=40;
        }
        if(ScorePoint == 20){
            n=50;
            a=8.0f;
        }
        if(ScorePoint == 50){
            n=60;
            a=6.0f;
        }
        if(ScorePoint == 100){
            n=100;
            a=5.0f;
        }
        if(life < 1)
        {
            move.gameStart = false;
            gameOver = true;
        }
        if (gameOver == true)
        {
            this.transform.position = new Vector3 (600,230,0);
            GetComponent<Text>().text = "Your Score = " + ScorePoint ;
            GetComponent<Text>().fontSize = 20;
        }
        if (player.transform.position.y < -10)
        {
            life = 0;
            GetComponent<Text>().text = "Your Score = " + ScorePoint ;
            GetComponent<Text>().fontSize = 20;
        }

        }
        
    }
}
