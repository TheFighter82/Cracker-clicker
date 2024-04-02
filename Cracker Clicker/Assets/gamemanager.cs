using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] cracker score;
    //[SerializeField] GameObject scoreText;
    //[SerializeField] GameObject score;

    void Start()
    {
        //scoreText = GameObject.FindGameObjectWithTag("scoreboard").GetComponent<Text>();
        //score = GameObject.FindGameObjectWithTag("buttonmanager").GetComponent<cracker>();
    }

    // Update is called once per frame
    public void UpdateScore(){
        scoreText.text = score.PointUpdate().ToString();
    }
}
