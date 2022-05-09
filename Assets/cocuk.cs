using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cocuk : MonoBehaviour
{
    public Transform zemin_1;
    public Transform zemin_2;
    Animator anim;
    public Rigidbody rigi;
    [SerializeField,Range(1,2000)]float speed = 5;
    [SerializeField,Range(1,1000)]float mesafe = 5;
    [SerializeField,Range(1,1000)]float hoplat = 5;


    

    private void Start()
    {
        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody>();
    }

    


    void Update()
    {
        if (Time.time > 0.5f)
        {
            hareket();
        }

       

    }
    void hareket()
    {
        rigi.velocity = new Vector3(0, rigi.velocity.y, speed * Time.deltaTime); //velocity = hýz. 

        float yatay = Input.GetAxisRaw("Horizontal"); //yataydaki ýnput deðerlerini alýyor.
        transform.position += new Vector3(yatay * mesafe * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.W))
        {
            rigi.AddForce(0, hoplat, 0, ForceMode.Impulse);
            //transform.position = new Vector3(transform.position.x, 700.0f, transform.position.z);
        }

        float xPos = Mathf.Clamp(transform.position.x, -2.0f, 2.0f);
        float yPos = Mathf.Clamp(transform.position.y, 0.0f, 2.5f);

        transform.position = new Vector3(xPos, yPos, transform.position.z);
    }
    
}
