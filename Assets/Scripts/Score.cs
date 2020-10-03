using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public float currentTime=0f;
    public float startTime=30f;
    public float _score=0f;
    [SerializeField] Text _ScoreResult;
    void Start()
    {
        currentTime=startTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime -=1*Time.deltaTime;
        
        if(currentTime<=0)
        {
            currentTime=0;
            

        }
        _score =currentTime*1000;
        _ScoreResult.text=_score.ToString();
    }
   
    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.tag == "Green"){
            currentTime+=5*Time.deltaTime;
            Destroy(collision.gameObject);
        }
        
    }
}
