using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.SceneManagement;
using LogitechGSDK;



public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float difficulty = 0.2f;
    [SerializeField] private float turnSpeed = 200f;
    private int steerValue;
    private PlayerActionControls playerActionControls;
    private DualShockGamepad gamepad;
    private void Awake(){
        playerActionControls = new PlayerActionControls();
    }
    private void OnEnable() {
        playerActionControls.Enable();
    }
    
    private void OnDisable(){
        playerActionControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {

        //gamepad = (DualShockGamepad)Gamepad.all[0];

    }
    // Update is called once per frame
    void Update()
    {
        //Read the movement value
        float movementInput = playerActionControls.Driving.Move.ReadValue<float>();
        float brakeRight = playerActionControls.Driving.BrakeRight.ReadValue<float>(); //Will be a 0 for not pressed. 1 for pressed
        float brakeLeft = playerActionControls.Driving.BrakeLeft.ReadValue<float>();

        if(brakeLeft !=0 && brakeRight !=0){
            StartCoroutine(PlayHapticsBoth(0.1f));
        }
        else if (brakeRight != 0){
            Debug.Log($"Brake Right Pressed value: {brakeRight}");
            transform.Rotate(0f, 1 * turnSpeed * Time.deltaTime, 0f);
            StartCoroutine(PlayHapticsRight(0.1f));
            gamepad.SetLightBarColor(Color.yellow);
        } else if (brakeLeft !=0){
            Debug.Log($"Brake Left Pressed value: {brakeLeft}");
            transform.Rotate(0f, -1 * turnSpeed * Time.deltaTime, 0.1f);
            StartCoroutine(PlayHapticsLeft(1f)); //Coroutine lets it go past 1 frame
            gamepad.SetLightBarColor(Color.cyan);
        } else {
            Gamepad.current.ResetHaptics();
        }
        //Moe the player
        Vector3 currentPosition = transform.position;
        //currentPosition.x += movementInput * speed * Time.deltaTime;

        speed += difficulty * Time.deltaTime; //Averages out speedgame over time

        transform.Rotate(0f, movementInput * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);  //deltaTime makes this framerate independent. 

    }
    
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Obstacle")){
            gamepad.SetLightBarColor(Color.red);
            Gamepad.current.ResetHaptics();
            SceneManager.LoadScene("Scene_MainMenu");
        }
    }

    public void Steer(int value)
    {
        steerValue = value;

    }
     IEnumerator PlayHapticsAndroid(float seconds){ //This vibrates the phone specifically, not the controller.
        Handheld.Vibrate();
        Gamepad.current.SetMotorSpeeds(.25f, 0);
        yield return new WaitForSeconds(seconds);
       // InputSystem.ResetHaptics();
    }

     IEnumerator PlayHapticsLeft(float seconds){
        Gamepad.current.SetMotorSpeeds(playerActionControls.Driving.BrakeLeft.ReadValue<float>(), 0);
        yield return new WaitForSeconds(seconds);
       // InputSystem.ResetHaptics();
    }
    IEnumerator PlayHapticsRight(float seconds){
        Gamepad.current.SetMotorSpeeds(0, playerActionControls.Driving.BrakeRight.ReadValue<float>());
        yield return new WaitForSeconds(seconds);
       // InputSystem.ResetHaptics();
    }
    IEnumerator PlayHapticsBoth(float seconds){
        Gamepad.current.SetMotorSpeeds(1f, 1f);
        yield return new WaitForSeconds(seconds);
        //InputSystem.ResetHaptics();
    }
}
