using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI _TextMeshPro;
    public float _Score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _TextMeshPro.text = "Score: " + _Score;

    }
}
