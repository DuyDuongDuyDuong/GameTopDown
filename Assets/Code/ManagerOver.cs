using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerOver : MonoBehaviour
{

   
    public GameObject gameOverUI;

    public void gameover()
    {
            gameOverUI.SetActive(true);
    }

    public void restar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
