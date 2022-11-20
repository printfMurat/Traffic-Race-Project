using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AracSecim : MonoBehaviour
{
    public GameObject[] Arabalar;
    public Text Arabaadý;
    int aktifaracindex=0;
    public ParticleSystem GecisEfekti;
    void Start()
    {
        Arabalar[aktifaracindex].SetActive(true);
        Arabaadý.text = Arabalar[aktifaracindex].GetComponent<aracbilgileri>().aracadi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ileri()
    {
        if (aktifaracindex != Arabalar.Length - 1)
        {
            Arabalar[aktifaracindex].SetActive(false);
            aktifaracindex++;
            Arabalar[aktifaracindex].SetActive(true);
            Arabaadý.text = Arabalar[aktifaracindex].GetComponent<aracbilgileri>().aracadi;
            GecisEfekti.Play();
        }
        else
        {
            Arabalar[aktifaracindex].SetActive(false);
            aktifaracindex = 0;
            Arabalar[aktifaracindex].SetActive(true);
            Arabaadý.text = Arabalar[aktifaracindex].GetComponent<aracbilgileri>().aracadi;
        }
    }
    public void Geri()
    {
        if (aktifaracindex != 0)
        {
            Arabalar[aktifaracindex].SetActive(false);
            aktifaracindex--;
            Arabalar[aktifaracindex].SetActive(true);
            Arabaadý.text =Arabalar[aktifaracindex].GetComponent<aracbilgileri>().aracadi;
            GecisEfekti.Play();
        }
        else
        {
            Arabalar[aktifaracindex].SetActive(false);
            aktifaracindex = Arabalar.Length - 1;
            Arabalar[aktifaracindex].SetActive(true);
            Arabaadý.text =Arabalar[aktifaracindex].GetComponent<aracbilgileri>().aracadi;
        }
    }
    public void basla()
    {
        PlayerPrefs.SetInt("SecilenArac",aktifaracindex);
        SceneManager.LoadScene("SampleScene");
    }
    
}
