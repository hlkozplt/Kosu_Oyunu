using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ana_menu_script : MonoBehaviour
{
  public void oyunu_baslat()
    {
        SceneManager.LoadScene("Scenes/oyun_sahnesi");
    }

    
    public void oyunu_kapat()
    {
        Application.Quit();
        Debug.Log("çýkýldý");
    }
}
