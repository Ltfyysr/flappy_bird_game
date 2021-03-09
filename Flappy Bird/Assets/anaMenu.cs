using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class anaMenu : MonoBehaviour
{
    public Text puanText;
    public Text puan;
    void Start()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("enYuksekPuanKayit");
        int puanGelen = PlayerPrefs.GetInt("puanKayit");
        puanText.text = "EN YÜKSEK PUAN= " + enYuksekPuan;
        puan.text = " PUAN= " + puanGelen;

    }

   
    void Update()
    {
        
    }

   public void oyunaGit()
    {

        SceneManager.LoadScene("level 1");
    }

   public void oyundanCik()
    {
        Application.Quit();
    }
}
