using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning2 : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
    if(col.gameObject.tag == "Player")
     {
         SceneManager.LoadScene("SceneMainMenu");
         if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();
     }
    }
  
}
