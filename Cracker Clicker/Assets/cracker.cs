using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cracker : MonoBehaviour
{
    public float score;
    private gamemanager gm;
    public RectTransform m_RectTransform;
    private float XPos = 100;
    private float YPos = 100;
    // Start is called before the first frame update
    void Start()
    {
        m_RectTransform = GameObject.FindGameObjectWithTag("button").GetComponent<RectTransform>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gamemanager>();
    }

    // Update is called once per frame
    public void PointsUp(){
        score += 1f;
        gm.UpdateScore();
        

    }  
    public void MoveButton(){
        XPos = Random.Range(300, -300);
        YPos = Random.Range(150, -150);
         m_RectTransform.anchoredPosition = new Vector2(XPos, YPos);
    }
    public float PointUpdate(){
        return score;
    }  
}