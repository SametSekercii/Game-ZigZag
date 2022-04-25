using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzik : MonoBehaviour
{
    static Muzik M;
    void Start()
    {

        if (!M)
        {
            M = this;
        }
        else if (M != this)
        {
            Destroy(this.gameObject);

        }

        DontDestroyOnLoad(M);
    }

    
    void Update()
    {
        
    }
}
