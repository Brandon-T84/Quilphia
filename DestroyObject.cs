using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject other; 

    // Update is called once per frame
    void Update()
    {
     
            if (BattleSystem.check == 2)
            {
            Debug.Log("yessir!");
                Destroy(other);
            }
    }
}
