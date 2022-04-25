using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarYap : MonoBehaviour
{
    public Transform SonKup;
   
    public GameObject YolPrefab;
    Vector3 SonKupYeri;
    PlayeController player1;
    
    Vector3 YapýlanYol=Vector3.zero;
    Camera Kamera;
    //float kameraadsad = Kamera.orthographicSize;
   





    void Start()
    {
        SonKupYeri=SonKup.position;
        InvokeRepeating("YolYap", 1, 0.5f);
        player1 = FindObjectOfType<PlayeController>();
        Kamera =Camera.main;

           
    }

    
    void Update()
    {
        
    }


    void YolYap()
    {
        float uzaklýk=Vector3.Distance(SonKupYeri, player1.transform.position);
        if (Kamera.orthographicSize * 2 < uzaklýk)
        {
            return;
        }
        
        int Zar = Random.Range(0, 11);

        if (Zar>=5)
        {
            YapýlanYol = new Vector3(SonKupYeri.x-2,SonKupYeri.y,SonKupYeri.z);
        }
        else
        {
            YapýlanYol = new Vector3(SonKupYeri.x, SonKupYeri.y, SonKupYeri.z+2);
        }

        
        GameObject YeniYol = Instantiate(YolPrefab, YapýlanYol, Quaternion.Euler(0, 0, 0), transform);

        YeniYol.transform.GetChild(0).gameObject.SetActive(Zar%3==2);

        SonKupYeri = YeniYol.transform.position;

        

    }

    int a;
}
