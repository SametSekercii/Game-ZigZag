using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKilit : MonoBehaviour
{
    Vector3 Uzakl�kfarki;
    public Transform OyuncuKonumu;
    void Start()
    {
        Uzakl�kfarki=OyuncuKonumu.position-transform.position;
        
    }

   
    void Update()
    {

        transform.position = OyuncuKonumu.position - Uzakl�kfarki;
        
    }
}
