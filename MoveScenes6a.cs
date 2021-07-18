using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes6a : MonoBehaviour
{

    public string callToGlobal;
    [SerializeField] private string newLevel;

    public GameObject sprite;
    public static string ob6a;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            ob6a = "hit";
            SceneManager.LoadScene(newLevel);

        }
    }



}
