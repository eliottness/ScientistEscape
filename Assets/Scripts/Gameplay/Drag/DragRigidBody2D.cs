using System.Collections;
using UnityEngine;

public class DragRigidBody2D : MonoBehaviour
{
    private Vector3 SpawnPosition;
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        SpawnPosition = this.gameObject.transform.position;
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

    public void Reset()
    {
        this.gameObject.transform.position = SpawnPosition;
    }

    /* Class Variables
    public float distance = 0.2f;
    public float damper = 0.5f; // damping ration in SpringJoint2D (0.0.- 1.0)
    public float frequency = 8.0f;
    public float drag = 1.0f; // this doesn't exist on 2D Spring...
    public float angularDrag = 5.0f;
    //var distance = 0.2;
    public bool attachToCenterOfMass = false;
    private SpringJoint2D springJoint;


    // Update
    public void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;

        Camera mainCamera = FindCamera();
        int layerMask = 1 << 8;
        RaycastHit2D hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, layerMask);
        Debug.Log("Layermask: " + LayerMask.LayerToName(8));
        // I have proxy collider objects (empty gameobjects with a 2D Collider) as a child of a 3D rigidbody - simulating collisions between 2D and 3D objects
        // I therefore set any 'touchable' object to layer 8 and use the layerMask above for all touchable items

        if (hit.collider != null && hit.rigidbody.isKinematic == true)
        {
            return;
        }

        if (hit.collider != null && hit.rigidbody.isKinematic == false)
        {
            if (!springJoint)
            {
                GameObject go = new GameObject("Rigidbody2D Dragger");
                Rigidbody2D body = go.AddComponent<Rigidbody2D>() as Rigidbody2D;
                springJoint = go.AddComponent<SpringJoint2D>() as SpringJoint2D;

                body.isKinematic = true;
            }

            springJoint.transform.position = hit.point;

            springJoint.distance = 0; // there is no distance in SpringJoint2D
            springJoint.dampingRatio = damper;// there is no damper in SpringJoint2D but there is a dampingRatio
                                              //springJoint.maxDistance = distance;  // there is no MaxDistance in the SpringJoint2D - but there is a 'distance' field
                                              //  see http://docs.unity3d.com/Documentation/ScriptReference/SpringJoint2D.html
                                              //springJoint.maxDistance = distance;
            springJoint.connectedBody = hit.rigidbody;


            // maybe check if the 'fraction' is normalised. See http://docs.unity3d.com/Documentation/ScriptReference/RaycastHit2D-fraction.html
            StartCoroutine("DragObject", hit.fraction);



        } // end of hit true condition

    } // end of update


    public IEnumerator DragObject(float distance)
    {
        float oldDrag = springJoint.connectedBody.drag;
        float oldAngularDrag = springJoint.connectedBody.angularDrag;

        springJoint.connectedBody.drag = drag;
        springJoint.connectedBody.angularDrag = angularDrag;

        Camera mainCamera = FindCamera();

        while (Input.GetMouseButton(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            springJoint.transform.position = ray.GetPoint(distance);
            yield return null;
        }

        if (springJoint.connectedBody)
        {
            springJoint.connectedBody.drag = oldDrag;
            springJoint.connectedBody.angularDrag = oldAngularDrag;
            springJoint.connectedBody = null;
        }
    }

    public Camera FindCamera()
    {
        if (GetComponent<Camera>())
            return GetComponent<Camera>();
        else
            return Camera.main;
    }*/
}

