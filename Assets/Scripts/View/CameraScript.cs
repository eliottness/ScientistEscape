using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    #if UNITY_EDITOR
    public bool activate = false;
    #else
    public bool activate = true;
    #endif
    public float speed = 0.003f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (!activate)
            return;
        
        var cameraPosition = Camera.main.gameObject.transform.position;
        cameraPosition.x += speed;
        Camera.main.gameObject.transform.position = cameraPosition;
    }
}
