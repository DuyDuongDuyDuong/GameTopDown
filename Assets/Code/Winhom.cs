using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winhom : MonoBehaviour
{
    public void Winhome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
      
        
    }
}
