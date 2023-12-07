using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foroyuncu : MonoBehaviour
{
    public Rigidbody fz;
    public float hiz;

    public int puan;

    public Text pp;
    public Text sureT;
    public float zaman;


    void Start()
    {
        fz = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        

        zaman += Time.deltaTime;
        sureT.text = zaman.ToString();

        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vek = new Vector3(yatay*2.5f, 0, dikey);

        fz.AddForce(vek*hiz);

    }
    void OnTriggerEnter (Collider other)
    {
        if (other) { puan++; }

        pp.text = "Toplanan Puanlar : " + puan.ToString();

        other.gameObject.SetActive(false);
    }

    void OnCollisionEnter (Collision cls)
    {
        string name = cls.gameObject.name;

        if (name == "finish")
        {
            Debug.Log(zaman.ToString());
            
            sureT.gameObject.SetActive(false);
        }
    }
}
