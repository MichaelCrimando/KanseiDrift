using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using TMPro;

public class DelayTest : MonoBehaviour
{
     public Color color1 = Color.red;
    public Color color2 = Color.blue;
    private PlayerActionControls playerActionControls;
    [SerializeField] private Camera cam;
    private float previousButtonValue = 0;
    private float buttonValue = 0;
    public TMP_Text fpsText;
    [SerializeField] private float pollingTime = 1f;
    private int frameCount;
    private float time;
    private int frameRate = 0;
   // private DualShockGamepad gamepad; //Just trying to get the lightbar working to test, somehow ruins everything



    // Awake runs before start
    private void Awake(){
        playerActionControls = new PlayerActionControls();

    }


    // Start is called before the first frame update
    void Start()
    {
        cam.backgroundColor = Color.white;
        //var gamepad = (DualShockGamepad)Gamepad.all[0];
        //gamepad.SetLightBarColor(Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        buttonValue = playerActionControls.DelayTest.LiterallyAnyButton.ReadValue<float>(); //Will be a 0 for not pressed. 1 for pressed

        if(playerActionControls.DelayTest.Back.ReadValue<float>() != 0){
            Back();
        } else if (buttonValue != 0 && buttonValue != previousButtonValue){
            literallyAnyButtonPressed();
        }
        previousButtonValue = buttonValue;
        fpsCounterUpdate();

    }
    public void Back(){
        SceneManager.LoadScene(0);    
    }

    private void OnEnable() {
        playerActionControls.Enable();
    }
    
    private void OnDisable(){
        playerActionControls.Disable();
    }
    public void literallyAnyButtonPressed(){
        if (cam.backgroundColor.Equals(color1)){
            cam.backgroundColor = color2;
            //gamepad.SetLightBarColor(color2);
        } else {
            cam.backgroundColor = color1;
            //gamepad.SetLightBarColor(color1);
        }
    }
    private void fpsCounterUpdate(){
        time += Time.deltaTime;
        frameCount++;
        if(time >= pollingTime){ //This gets average fps. Could theorteically do  1 / Time.deltaTime for instantaneous fps, but it might actually be less accurate
            frameRate = Mathf.RoundToInt(frameCount / time);
            fpsText.text = $"{frameRate} FPS";

            time -=  pollingTime; //Dont set to 0 since more time may have elapsed already
            frameCount = 0;
        }
    }
}
