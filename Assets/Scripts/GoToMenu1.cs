using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu1 : MonoBehaviour
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
            SceneManager.LoadScene("SceneMainmenu");
            if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();

        }
        if(Input.anyKey)
        {
          SceneManager.LoadScene("SceneMainmenu");
          if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();
        }

        
        _CounTDownTimer.text=currentTime.ToString();
    }
}
