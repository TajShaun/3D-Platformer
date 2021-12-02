using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
  public void PlayScreen(){
SceneManager.LoadScene("Play");
  }
    public void Options(){
SceneManager.LoadScene("Options");
  }
  public void StartScreen(){
SceneManager.LoadScene("Start");
  }
  public void Exit(){
  Application.Quit();
  }

}  
