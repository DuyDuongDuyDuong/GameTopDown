using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextBackUI : MonoBehaviour
{
    public void LV2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        BulletScriptt._DameHit = 1;
        Debug.Log(BulletScriptt._DameHit );
        LvScript.Lv = 1;
        Scout3._Sconre = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void BackHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
      

    }
    
}
