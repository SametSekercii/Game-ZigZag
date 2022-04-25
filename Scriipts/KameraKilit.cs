using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKilit : MonoBehaviour
{
    Vector3 Uzaklýkfarki;
    public Transform OyuncuKonumu;
    void Start()
    {
        Uzaklýkfarki=OyuncuKonumu.position-transform.position;
        
    }

   
    void Update()
    {

        transform.position = OyuncuKonumu.position - Uzaklýkfarki;
        
    }
}
