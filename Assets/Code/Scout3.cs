using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scout3 : MonoBehaviour
{
    public TextMeshProUGUI _TextMeshPro;
    public static int _Sconre = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _TextMeshPro.text = "Score: " + _Sconre;
    }
}
