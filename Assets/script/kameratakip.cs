using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public GameObject oyuncu;
    public Vector3 fark;
    void Start()
    {
        fark = transform.position - oyuncu.transform.position;
    }

    
    void LateUpdate()
    {
        transform.position = fark + oyuncu.transform.position;
    }
}
