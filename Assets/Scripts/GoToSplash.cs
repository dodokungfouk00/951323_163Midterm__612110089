using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToSplash : MonoBehaviour
{
    public float currentTime=0f;
    public float startTime=10f;
    [SerializeField] Text _CounTDownTimer;
    void Start()
    {
        currentTime=startTime;
    }

    
    void Update()
    {
        currentTime -=1*Time.deltaTime;
        
        if(currentTime<=0 )
        {
            currentTime=0;
            SceneManager.LoadScene("SceneSplash");
            if (SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Stop();

        }
        if(Input.anyKey)
        {
            currentTime=5;
        }
        

        
        _CounTDownTimer.text=currentTime.ToString();
    }
}
