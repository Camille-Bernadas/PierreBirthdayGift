using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScoreManager : MonoBehaviour, IDataPersistence
{
    public TextMeshProUGUI gold;
    public TextMeshProUGUI silver;
    public TextMeshProUGUI bronze;


    public void SaveData(GameData gameData){}
    public void LoadData(GameData gameData){
        int[] scores = gameData.highscores;
        gold.text = scores[0].ToString();
        silver.text = scores[1].ToString();
        bronze.text = scores[2].ToString();
    }

    public void BackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

}
