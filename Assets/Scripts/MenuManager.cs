using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void LoadShop()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void LoadHighScore()
    {
        SceneManager.LoadScene("HighScoreScene");
    }
}
