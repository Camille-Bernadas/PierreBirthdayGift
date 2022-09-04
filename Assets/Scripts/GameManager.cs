using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IDataPersistence
{
    public AudioSource audioSource;
    public AudioClip drink;
    public AudioClip aahh;
    public AudioClip death;
    public BirdFlight player;
    private bool died;

    public static GameManager instance;
    public static GameManager GetInstance() {
        if (instance == null) {
            instance = new GameManager();
        }
        return instance;
    }
    void Awake(){
        instance = this;
    }
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        died = false;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if(!died){
            died = true;
            audioSource.pitch = 1f;
            audioSource.PlayOneShot(death);
            gameOverCanvas.SetActive(true);
            player.isAlive = false;
            DataPersistenceManager.instance.SaveGame();
        }
        
    }

    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void ScoreChanged(int score){
        if(score%10 == 0){
            audioSource.pitch = 1f;
            audioSource.PlayOneShot(aahh);
        }
        else{
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.PlayOneShot(drink);
        }
    }

    public void SaveData(GameData gameData) {
        int[] scores = gameData.highscores;
        for (int i = 0; i < scores.Length; i++){
            if(Score.score > scores[i]){
                int previousValue = 0;
                int newValue = Score.score;
                for (int j = i; j < scores.Length; j++){
                    previousValue = scores[j];
                    scores[j] = newValue;
                    newValue = previousValue;

                }
                    return;
            }
        }
    }
    public void LoadData(GameData gameData) { }
}
