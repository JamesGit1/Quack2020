using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthHandler : MonoBehaviour

 
{
    private TextMeshProUGUI hello;
    // Start is called before the first frame update
    void Start()
    {
        Health test = new Health(100);

        hello = FindObjectOfType<TextMeshProUGUI>();
        

        Debug.Log("HP" + test.GetHP());
        test.Dmg(10);
        hello.text = Convert.ToString(test.GetHP());
        Debug.Log("HP" + test.GetHP());
        test.Heal(110);
        Debug.Log("HP" + test.GetHP());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
