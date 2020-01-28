using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    private int Next;
    public Animator Transition;
    private void Start()
    {
        Next = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        Transition.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(Next);
    }
}
