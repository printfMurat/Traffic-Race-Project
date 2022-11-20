using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class genelayarlar : MonoBehaviour
{
    public GameObject[] Araclar;
    public GameObject Spawnnoktasi;

    public GameObject[] YapayZekaSpawnnoktalari;
    public GameObject[] YapayZekaAraclari;
    // Start is called before the first frame update
    void Start()
    {
       
       GameObject arabam = Instantiate(Araclar[PlayerPrefs.GetInt("SecilenArac")], Spawnnoktasi.transform.position, Spawnnoktasi.transform.rotation);
        
        GameObject.FindWithTag("MainCamera").GetComponent<CameraControl>().target[0] = arabam.transform.Find("PozisyonAl");
        GameObject.FindWithTag("MainCamera").GetComponent<CameraControl>().target[1] = arabam.transform.Find("Pivot");

        GameObject.FindWithTag("OyunKontrol").GetComponent<KameraGecisKontrol>().kameralar[1] = arabam.transform.Find("Kameralar/OnKaput").gameObject;
        GameObject.FindWithTag("OyunKontrol").GetComponent<KameraGecisKontrol>().kameralar[2] = arabam.transform.Find("Kameralar/AracIci").gameObject;
        for(int i = 0; i < 3; i++)
        {
            int randomdeger=Random.Range(0,YapayZekaAraclari.Length-1);
        GameObject OlusanArac = Instantiate(YapayZekaAraclari[randomdeger], YapayZekaSpawnnoktalari[i].transform.position, YapayZekaSpawnnoktalari[i].transform.rotation);
        OlusanArac.GetComponent<YapayZekaController>().SpawnNoktasýIndex = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
