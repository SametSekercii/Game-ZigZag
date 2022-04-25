using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayeController : MonoBehaviour
{
    public Transform PlayerTransform;
    public float ms = 1;
    bool StageisRight = true;
     GameManager GM;
     Animator PlayerAnim;
    public Transform AsagýISIN;
    public Text Score, HighScore;
    public int High_Score { get; private set; }
    public int s_Score { get; private set; }
    
    
   
    


    

    void Start()
    {
        
        GM = GameObject.FindObjectOfType<GameManager>();
        PlayerAnim = gameObject.GetComponent<Animator>();
        High_Score=PlayerPrefs.GetInt("HighScore");
        HighScore.text=High_Score.ToString();
        
       
    } 

    
    void Update()
    {
        if (!GM.GameSitutaion) return;
        
        PlayerAnim.SetTrigger("OyunBasladi");
        PlayerTransform.position += transform.forward * Time.deltaTime * ms;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DonusYap();
            
        }
        DusmeKontrolu();
        
    }

    void DonusYap()
    {
        if (StageisRight)
        {
            PlayerTransform.Rotate(new Vector3(0, 1, 0), -90);


        }

        else
        {
            PlayerTransform.Rotate(new Vector3(0, 1, 0), 90);

        }
        StageisRight = !StageisRight;

    }

    void DusmeKontrolu(){

        if (!Physics.Raycast(AsagýISIN.position,new Vector3(0,-1,0)))
        {
            PlayerAnim.SetTrigger("Dustu");
            GM.YenidenBaslat();

        }


       
    }

    public void SkorYap()
    {
        s_Score++;

        if(s_Score > High_Score)
        {
            High_Score = s_Score;
            PlayerPrefs.SetInt("HighScore", High_Score);
            HighScore.text = High_Score.ToString();
            

        }
        Score.text=s_Score.ToString();

        //Destroy();

    }

    private void OnTriggerEnter(Collider collision)
    {
        Tag KontrolTag =collision.gameObject.GetComponent<Tag>();

        if (KontrolTag== null)
        {
            
            return;
        }
        
        TAGLAR CTag = KontrolTag.taglar;
            
        if(CTag.Equals(TAGLAR.Kristal))
        {
            
            SkorYap();


            
            
        }
        Destroy(collision.gameObject);
    }
    

    void Destroy()
    {
        
        
    }


}
