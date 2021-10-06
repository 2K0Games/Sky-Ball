using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {
    public Transform lookAt;
   
    private Vector3 desiredPosition;
    private Vector3 offset;

   

    private float smoothSpeed = 7.5f;
    private float distance= 10.0f;
    private float yOffset = 3.5f;

	// Use this for initialization
	void Start () {
        offset = new Vector3(0, yOffset, -1f * distance);
	}
	
	// Camera for controller
    
}
