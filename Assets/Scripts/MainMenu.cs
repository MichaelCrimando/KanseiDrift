using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private string url;
    private PlayerActionControls playerActionControls;
    
    private void Awake(){
        playerActionControls = new PlayerActionControls();
    }

    private void OnEnable() {
        playerActionControls.Enable();
    }
    
    private void OnDisable(){
        playerActionControls.Disable();
    }

    private void Start(){
        Application.targetFrameRate = 60;
        int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);
        highScoreText.text = $"High Score: {highScore}";
    }

    void Update(){
        if(playerActionControls.Menu.Play.ReadValue<float>() != 0){
            Play();
        } else if (playerActionControls.Menu.Terms.ReadValue<float>() != 0){
            Open();
        } else if (playerActionControls.Menu.DelayTest.ReadValue<float>() != 0){
            DelayTest();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);    
    }

    public void DelayTest()
    {
        SceneManager.LoadScene(3);    
    }

    public void Open(){
        Application.OpenURL(url);
    }
}
