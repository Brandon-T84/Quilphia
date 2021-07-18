using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjecta9a : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject other; 

    // Update is called once per frame
    void Update()
    {
     
            if (BattleSystem.check9a == 10)
            {
            Debug.Log("yessir!");
                Destroy(other);
            }
    }
}
