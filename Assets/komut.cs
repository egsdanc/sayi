using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public static class Globals
{

    public static int say=0;
    public static int say1=0;
    public static float xPos;
    public static float yPos;
    public static int posSayac=0;
    public static int kisiSayac = 0;
    public static int baslangic = 0;
    public static int kontrol = 0;
    public static int kontrol1 = 0;
   


}

public class komut : MonoBehaviour
{
    public GameObject[] kup;
    private sayac dg1;
    private sayac dg2;
    private GameObject d1;
    private GameObject d2;
   



    public static System.Random r = new System.Random();
    private TextMeshPro txtm;
    private TextMeshPro txt;


    int sayi = r.Next(-10, 20);
   
    // Start is called before the first frame update
    void Start()
    {
       
       
       

        d1 = GameObject.FindGameObjectWithTag("puan1");
        d2 = GameObject.FindGameObjectWithTag("puan2");
      
        dg1 = d1.GetComponent<sayac>();
        dg2 = d2.GetComponent<sayac>();

        txtm = GetComponent<TextMeshPro>();
        txt = GetComponent<TextMeshPro>();


        txtm.text = sayi.ToString();
        //GetComponent<TextMeshPro>().text = sayi.ToString();

        ////txtm.color = Color.red;

        txt.color = Color.red;


    }

    // Update is called once per frame
    void Update()
    {
   



        //if (txt.color != Color.red)

        //{
        //    //Debug.Log("AAAAAAAAAAAAA");

        //}



        if (Globals.posSayac == 0 )
            {
            if (Globals.baslangic == 1)
            {    
                txtm.color = Color.green;
            }
            if (this.gameObject.transform.position.x == Globals.xPos)
                {
                    //////GetComponent<Renderer>().material.color = Color.red;
                    ///a=1
                    txt.color = Color.red;
                    //this.gameObject.color = Color.red;
                    //   GetComponent<TextMesh>().text = "Hello World";
                    // GetComponentColor = color.Red;
                    //GetComponent<Renderer>().material.color = new Color(0, 255, 0);

                }
           

        }
            else if(Globals.posSayac == 1) 
            {
            if (Globals.baslangic == 1)
            {
                txtm.color = Color.green;
            }
            if (this.gameObject.transform.position.y == Globals.yPos)
                {
                    //////GetComponent<Renderer>().material.color = Color.red;
                    txt.color = Color.red;
                    //this.gameObject.color = Color.red;
                    //   GetComponent<TextMesh>().text = "Hello World";
                    // GetComponentColor = color.Red;
                    //GetComponent<Renderer>().material.color = new Color(0, 255, 0);

                }
        
            }


     


    }

    void OnMouseDown()
    {

        float geciciY = this.gameObject.transform.position.y;
        float geciciX = this.gameObject.transform.position.x;


        //Get the renderer component of the object and change the material color to blue

        if (Globals.posSayac == 0)
        {
            if (geciciX == Globals.xPos || Globals.baslangic == 0)
            {


                Globals.baslangic = 1;

                Destroy(this.gameObject);
                Globals.yPos = this.gameObject.transform.position.y;
                Globals.xPos = this.gameObject.transform.position.x;
                if (Globals.posSayac == 0)
                    Globals.posSayac = 1;
                else
                    Globals.posSayac = 0;

                if (Globals.kisiSayac == 0)
                {
                    Globals.kisiSayac = 1;
                    Globals.say += sayi;
                    dg1.deger1 = Globals.say;


                    //txtm.text = Globals.say.ToString();

                    //skortxt1.text = Globals.say.ToString();
                }
                else
                {

                    Globals.kisiSayac = 0;
                    Globals.say1 += sayi;
                    dg2.deger2 = Globals.say1;

                    //txtm.text = Globals.say1.ToString();


                    //skortxt2.text = Globals.say1.ToString();
                }


            }
        }
        else
        {
            if (geciciY == Globals.yPos || Globals.baslangic == 0)
            {
                Globals.baslangic = 1;
                Destroy(this.gameObject);
                Globals.yPos = this.gameObject.transform.position.y;
                Globals.xPos = this.gameObject.transform.position.x;
                if (Globals.posSayac == 0)
                    Globals.posSayac = 1;
                else
                    Globals.posSayac = 0;

                if (Globals.kisiSayac == 0)
                {
                    Globals.kisiSayac = 1;
                    Globals.say += sayi;
                    dg1.deger1 = Globals.say;

                    //txtm.text = Globals.say.ToString();

                    //skortxt1.text = Globals.say.ToString();
                }
                else
                {

                    Globals.kisiSayac = 0;
                    Globals.say1 += sayi;
                    dg2.deger2 = Globals.say1;


                    //txtm.text = Globals.say1.ToString();


                    //skortxt2.text = Globals.say1.ToString();
                }


            }

        }



        //Debug.Log(Globals.yPos);
        //Debug.Log(Globals.xPos);



        kup = GameObject.FindGameObjectsWithTag("ekle");
        int tagX = 0;
        int tagY = 0;
        foreach (GameObject k in kup)
        {

            if (k.transform.position.x == geciciX)
            {      //Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
                tagX++;
            }
            if (k.transform.position.y ==geciciY)
            {      //Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
                tagY++;
            }
         
            //Debug.Log(k.transform.position.x);
            //Debug.Log(k.transform.position.y);
        }
        if(Globals.posSayac==0 && (tagX == 1))
       
        {
            Debug.Log("oyun bitti");
        }
        if (Globals.posSayac == 1 && (tagY == 1))

        {
            Debug.Log("oyun bitti");
        }
        //Debug.Log(tagX);
    } 


    



}


