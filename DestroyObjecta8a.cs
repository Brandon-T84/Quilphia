using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjecta8a : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject other; 

    // Update is called once per frame
    void Update()
    {
     
            if (BattleSystem.check8a == 9)
            {
            Debug.Log("yessir!");
                Destroy(other);
            }
    }
}
