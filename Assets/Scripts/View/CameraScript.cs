using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;

public class CameraScript : MonoBehaviour
{
    #if UNITY_EDITOR
    public bool activate = false;
    #else
    public bool activate = true;
    #endif
    public float speed = 0.003f;
    readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
	if (model.player.health.IsAlive)
    		Move();
    }

    public void Move()
    {
        var cameraPosition = Camera.main.gameObject.transform.position;
        if (!activate)
            return;
        
        cameraPosition.x += speed;
        Camera.main.gameObject.transform.position = cameraPosition;
    }
}
