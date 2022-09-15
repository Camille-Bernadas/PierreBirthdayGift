using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour, IDataPersistence
{

    public void SaveData(GameData gameData) { }
    public void LoadData(GameData gameData)
    {
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
