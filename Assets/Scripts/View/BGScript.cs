using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScript : MonoBehaviour
{
    private float startpos, length;
    public GameObject cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float tmp = cam.transform.position.x * (1 - parallaxEffect);
        float dist = cam.transform.position.x * parallaxEffect;

        // potentialy do y effect
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (tmp - length >= startpos)
            startpos += length;
        else if (tmp + length < startpos)
            startpos -= length;
    }
}
