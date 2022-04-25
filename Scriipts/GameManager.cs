using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameSitutaion = false;


    void Start()
    {
        OyunBaslat();
    }
    public void OyunBaslat()
    {

        GameSitutaion = true;

    }
    public void YenidenBaslat()
    {

        Invoke("Load", 1f);

    }
    
    void Load()
    {
        SceneManager.LoadScene(0);

    }
}
