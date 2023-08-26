using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logicgamestart : MonoBehaviour
{
   public void GameStart()
    {
        SceneManager.LoadScene("GameStart");
    }
    public void GameExit()
    {
        Application.Quit();
    }
   
}
