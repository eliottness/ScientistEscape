using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speed = 0.003f;
    public GameObject rightWall;
    public GameObject leftWall;
    
    // Start is called before the first frame update
    void Start()
    {
        rightWall = GameObject.Find("RightWall");
        leftWall = GameObject.Find("LeftWall");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        var cameraPosition = Camera.main.gameObject.transform.position;
        var rightWallPosition = rightWall.gameObject.transform.position;
        var leftWallPosition = leftWall.gameObject.transform.position;
        
        cameraPosition.x += speed;
        rightWallPosition.x += speed;
        leftWallPosition.x += speed;
        
        Camera.main.gameObject.transform.position = cameraPosition;
        rightWall.gameObject.transform.position = rightWallPosition;
        leftWall.gameObject.transform.position = leftWallPosition;
    }
}
