using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int gameStartScene;

    public void StartingGame()
    {
        SceneManager.LoadScene("1Niveaux");
    }
}
