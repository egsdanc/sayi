using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class sayac : MonoBehaviour
{
    private TextMeshPro tx;
    public int deger1=0;
    public int deger2=0;

    // Start is called before the first frame update
    void Start()
    {
      tx = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "puan1")
        {
            tx.text = deger1.ToString();
        }
        else if (gameObject.tag == "puan2")
        {
            tx.text = deger2.ToString();
        }
    }
}
