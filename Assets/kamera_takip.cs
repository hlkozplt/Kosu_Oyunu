using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour
{
    [SerializeField, Range(0, 1000)] float mesafe = 5;
    [SerializeField, Range(0, 1000)] float LerpTime = 0.2f;
    [SerializeField, Range(0, 1000)] float yPos = 1.0f;
    public GameObject cocuk;
 
    void LateUpdate() //takip kodlar� LateUpdate yaz�l�r.
    {
        
        Vector3 Lerp = cocuk.transform.position+Vector3.up*yPos; //�ocu�un pozisyonu + bir y�kseklik 
        transform.position = Vector3.Lerp(transform.position, Lerp, LerpTime); //kameran�n pozisyonunu sinematik ge�i�le yumu�atarak �ocu�a yakla�t�r�r
        transform.position = new Vector3(transform.position.x, transform.position.y, cocuk.transform.position.z - mesafe); //kameran�n pozisyonu z ekseninde �ocuktan mesafe kadar geride kal�r.
        //transform.LookAt(cocuk.transform.position + Vector3.up); buras� kameran�n s�rekli karaktere bakmas�n� sa�lar.
    }

    
}
