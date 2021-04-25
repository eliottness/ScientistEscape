using Platformer.View;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DeleteFire : MonoBehaviour
{
    private Tilemap tiles;
    public float randomDelayAnim = 20f;
    public AudioClip fireExtinguish;
    
    // Start is called before the first frame update
    void Awake()
    {
        tiles = GetComponent<Tilemap>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Object")
        {
            AudioSource.PlayClipAtPoint(fireExtinguish ,this.gameObject.transform.position);
            collider.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        } 
    }
}
