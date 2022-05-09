using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klonla_script : MonoBehaviour
{
    public GameObject coin;
    public Transform cocuk;
    public GameObject canavar;
    public GameObject tas;

    float silinme_zamaný = 5.00f;
    

   


    private void Start()
    {
        InvokeRepeating("nesne_klonla", 0, 1.00f);
    }

    void nesne_klonla()
    {
        int rastsayi = Random.Range(3, 100);

        if(rastsayi>3 && rastsayi<70)
        {
            klonla(coin, 0.40f);
        }
        if(rastsayi>70 && rastsayi<90)
        {
            klonla(canavar, 0.00f);
        }
        if (rastsayi > 90 && rastsayi < 100)
        {
            klonla(tas, 0.30f);
        }
    }
    
    void klonla(GameObject nesne, float Y_koordinat)
    {
        GameObject yeni_klon = Instantiate(nesne);
        float rast_xPos = Random.Range(-1.90f, 1.40f);
        int rast_sayi = Random.Range(0, 10);
        
        if(rast_sayi>0)
        {
            yeni_klon.transform.position = new Vector3(rast_xPos, Y_koordinat, cocuk.position.z + 20.00f);

        }
   
        Destroy(yeni_klon, silinme_zamaný);
    }
    
}
