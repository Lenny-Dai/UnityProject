using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class stars : MonoBehaviour
{
    // Start is called before the first frame update
    float lastti=0f;
    float frame=0.016f;
    //float degv=0;

    int timer=0;
    int framed=1;
    GameObject bullet1=null;
    Sprite[] star=new Sprite[10];


    
    void Start()
    {
        bullet1=Resources.Load("enemy/prefab/bulletclass") as GameObject;
        for(int i=1;i<=8;i++){
            star[i]=Resources.Load<Sprite>("enemy/stars/star_"+i) as Sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time-lastti>frame){
            timer++;
            framed=1;
            lastti=Time.time;
        }
        else{
            framed=0;
        }
        //float t1=240,t2=300,t3=360,t4=600,t5=660;
        if(timer%15==0&&framed==1){
            
            int ti=12;
            int deg=UnityEngine.Random.Range(0,360);;
            for (int i=0;i<=ti;i++){
                GameObject bul=Instantiate(bullet1);
                basicbullet basb=bul.GetComponent<basicbullet>();
                basb.chplace(transform.localPosition.x,transform.localPosition.y);
                basb.chdeg(deg+i*360/ti);
                basb.chrotv(3f);
                basb.chv(3f);
                basb.chimg(star[UnityEngine.Random.Range(1,8)]);
            }
            
        }
    }
}
