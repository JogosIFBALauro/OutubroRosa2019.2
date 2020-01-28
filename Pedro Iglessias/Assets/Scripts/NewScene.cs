using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class NewScene : MonoBehaviour
{
    public int scene;
    public string teste;
  public void LoadIndex(int scene)
    {
        SceneManager.LoadScene(scene);
    }

}
