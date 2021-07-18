using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject1a : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject other1a;
    
    // Update is called once per frame
    void Update()
    {

        if (BattleSystem.check1a == 3)
        {
            Debug.Log("yessir!");
            Destroy(other1a);
        }
    }
}
