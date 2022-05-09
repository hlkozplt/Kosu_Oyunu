using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour
{
    [SerializeField, Range(0, 1000)] float mesafe = 5;
    [SerializeField, Range(0, 1000)] float LerpTime = 0.2f;
    [SerializeField, Range(0, 1000)] float yPos = 1.0f;
    public GameObject cocuk;
 
    void LateUpdate() //takip kodlarý LateUpdate yazýlýr.
    {
        
        Vector3 Lerp = cocuk.transform.position+Vector3.up*yPos; //çocuðun pozisyonu + bir yükseklik 
        transform.position = Vector3.Lerp(transform.position, Lerp, LerpTime); //kameranýn pozisyonunu sinematik geçiþle yumuþatarak çocuða yaklaþtýrýr
        transform.position = new Vector3(transform.position.x, transform.position.y, cocuk.transform.position.z - mesafe); //kameranýn pozisyonu z ekseninde çocuktan mesafe kadar geride kalýr.
        //transform.LookAt(cocuk.transform.position + Vector3.up); burasý kameranýn sürekli karaktere bakmasýný saðlar.
    }

    
}
