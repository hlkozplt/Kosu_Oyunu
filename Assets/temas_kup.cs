using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class temas_kup : MonoBehaviour
{
    public Transform zemin_1;
    public Transform zemin_2;
    int puan = 0;
    TextMeshProUGUI puan_txt;
    public GameObject durdur_pnl;
    public GameObject oyun_bitti_pnl;



    private void Start()
    {
        puan_txt = GameObject.Find("Canvas/puan_txt").GetComponent<TextMeshProUGUI>();
        //puan_txt dosyamýzýn konumuna eriþtik
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "yol_uzat_1")
        {
            zemin_2.position = new Vector3(zemin_1.position.x, zemin_1.position.y, zemin_1.position.z + 40);
        }

        if(other.gameObject.name == "yol_uzat_2")
        {
            zemin_1.position = new Vector3(zemin_2.position.x, zemin_2.position.y, zemin_2.position.z + 40);
        }
   
            if (other.gameObject.tag == "coin")     //if komutuyla eðer çarpýþan objenin tagi elma ise skoru 10 arttýr dedik
            {
                puan += 1;

                 puan_txt.text =  puan.ToString();
            Destroy(other.gameObject);
            
            }
            if (other.gameObject.tag == "engel")

            {
            Time.timeScale = 0;
            oyun_bitti_pnl.SetActive(true);
            }

    }
    bool oyun_durduruldu = false;
    public void oyunu_durdur_btn()
    {
        oyun_durduruldu = !oyun_durduruldu;

        if(oyun_durduruldu == false)
        {
            Time.timeScale = 0;
            durdur_pnl.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            
        }
 
    }
    bool devam_et = true;
    public void devam_ettir()
    {
        devam_et = !devam_et;

        if(devam_et=!devam_et)
        {
            durdur_pnl.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void yeniden_baslat()
    {
        SceneManager.LoadScene("Scenes/oyun_sahnesi");
        Time.timeScale = 1;
    }
   
   
}
