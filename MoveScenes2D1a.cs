using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{

    public string callToGlobal;
    [SerializeField] private string newLevel;

    public GameObject sprite;
    public static string ob1a;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            ob1a = "hit";
            SceneManager.LoadScene(newLevel);
            
        }
    }

  

}
