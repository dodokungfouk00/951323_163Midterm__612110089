using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage1 : MonoBehaviour
{
    public void _GotoStage1(){
        SceneManager.LoadScene("SceneStage1");
    }
    public void _GotoStage2(){
          SceneManager.LoadScene("SceneStage2");
    }
}
