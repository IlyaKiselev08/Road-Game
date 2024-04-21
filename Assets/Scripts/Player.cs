using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float startPosX, deadZone = 1, posX;
    public float sideSpeed = 3;
    public float joystickX;
    public float sensivity = 5;
    public float border;
    public int coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPosX = Input.mousePosition.x - Screen.width / 2;
        }
        if(Input.GetMouseButton(0))
        {
            posX = Input.mousePosition.x;
        } 
        if(Input.GetMouseButtonUp(0))
        {
            startPosX = 0;
            posX = 0;
        }
         joystickX =  1f / Screen.width * (startPosX - posX);
        joystickX = Mathf.Clamp(joystickX, -1f, 1f);
        transform.Translate(sideSpeed * Time.deltaTime * -joystickX * sensivity, 0, 0);


        if (transform.position.x < -border)
        {
            transform.position = new Vector3(-border, transform.position.y, transform.position.z);
        }
        if (transform.position.x > border)
        {
            transform.position = new Vector3(border, transform.position.y, transform.position.z);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Car"))
        {
            SceneManager.LoadScene(0);
        }
        if(other.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            Destroy(other.gameObject);
        }
    }
}
