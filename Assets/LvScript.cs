using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvScript : MonoBehaviour
{
    public TextMeshProUGUI _TextMeshPro;
    public static int Lv = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _TextMeshPro.text = "Level: " + Lv;
    }
}
