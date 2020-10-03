using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTime1 : MonoBehaviour
{

    public float currentTime=0f;
    public float startTime=10f;
    [SerializeField] Text _CounTDownTimer;
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
            //SceneManager.LoadScene("SceneMainmenu");

        }
        
        _CounTDownTimer.text=currentTime.ToString();
    }
   
    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.tag == "Green"){
            currentTime+=5*Time.deltaTime;
            Destroy(collision.gameObject);
        }
        
    }
}
