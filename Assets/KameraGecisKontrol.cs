using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraGecisKontrol : MonoBehaviour
{
    public GameObject[] kameralar;
    int aktifkamera=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            KameralarýKapat();
            aktifkamera++;
          
            if (aktifkamera >kameralar.Length-1)
            {
                aktifkamera = 0;
            }
                kameralar[aktifkamera].SetActive(true);
            
            
        }
    }
    void KameralarýKapat()
    {
        foreach(var cam in kameralar)
        {
            cam.SetActive(false);
        }
    }
}
