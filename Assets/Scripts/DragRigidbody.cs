using UnityEngine;
using System;
using System.Collections;


public class DragRigidbody:MonoBehaviour
{
    public float spring = 50.0f;
    public float damper = 5.0f;
    public float drag = 10.0f;
    public float angularDrag = 5.0f;
    public float distance = 0.2f;
    public bool attachToCenterOfMass = false;
    
    SpringJoint springJoint;
    
    public void Update()
    {
    	// Make sure the user pressed the mouse down
    	if (!Input.GetMouseButtonDown (0))
    		return;
    
    	Camera mainCamera = FindCamera();
    		
    	// We need to actually hit an object
    	RaycastHit hit = new RaycastHit();
    	if (!Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition),  out hit, 100.0f))
    		return;
    	// We need to hit a rigidbody that is not kinematic
    	if ((hit.rigidbody == null) || hit.rigidbody.isKinematic)
    		return;
    	
    	if (springJoint == null)
    	{
    		GameObject go = new GameObject("Rigidbody dragger");
    		Rigidbody body = go.AddComponent<Rigidbody>();
    		springJoint = go.AddComponent<SpringJoint>();
    		body.isKinematic = true;
    	}
    	
    	springJoint.transform.position = hit.point;
    	if (attachToCenterOfMass)
    	{
    		Vector3 anchor = transform.TransformDirection(hit.rigidbody.centerOfMass) + hit.rigidbody.transform.position;
    		anchor = springJoint.transform.InverseTransformPoint(anchor);
    		springJoint.anchor = anchor;
    	}
    	else
    	{
    		springJoint.anchor = Vector3.zero;
    	}
    	
    	springJoint.spring = spring;
    	springJoint.damper = damper;
    	springJoint.maxDistance = distance;
    	springJoint.connectedBody = hit.rigidbody;
    	
    	StartCoroutine ("DragObject", hit.distance);
    }
    
    public IEnumerator DragObject(float distance)
    {
    	float oldDrag = springJoint.connectedBody.drag;
    	float oldAngularDrag = springJoint.connectedBody.angularDrag;
    	springJoint.connectedBody.drag = drag;
    	springJoint.connectedBody.angularDrag = angularDrag;
    	Camera mainCamera = FindCamera();
    	while (Input.GetMouseButton (0))
    	{
    		Ray ray = mainCamera.ScreenPointToRay (Input.mousePosition);
    		springJoint.transform.position = ray.GetPoint(distance);
    		yield return null;
    	}
    	if (springJoint.connectedBody != null)
    	{
    		springJoint.connectedBody.drag = oldDrag;
    		springJoint.connectedBody.angularDrag = oldAngularDrag;
    		springJoint.connectedBody = null;
    	}
    }
    
    public Camera FindCamera()
    {
    	if (GetComponent<Camera>() != null)
    		return GetComponent<Camera>();
    	else
    		return Camera.main;
    }
}