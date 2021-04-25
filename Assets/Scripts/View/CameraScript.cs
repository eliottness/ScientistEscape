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

	public float initialSpeed = 0.01f;
    public float speed = 0.01f;
	public float maxSpeed = 0.02f;
	public float acceleration = 0.001f; // Speed acceleration
	public float delay = 5f; // Number of seconds between each acceleration

	private float timer = 0.0f;

    readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();

    // Start is called before the first frame update
    void Start()
    {
		Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (model.player.health.IsAlive)
    		Move();

		timer += Time.deltaTime;
		
		if (timer >= delay)
		{
			if (speed <= maxSpeed)
				speed += acceleration;

			timer -= delay;
			Time.timeScale = 1.0f;
		}
    }

    public void reset()
    {
	    speed = initialSpeed;
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
