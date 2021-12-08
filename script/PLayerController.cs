using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PLayerController : MonoBehaviour {
	public float speed;
    public Text countText;
	public int winCount;  

	private Rigidbody rb;
    private Transform camTransform;
	public int count;
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
        camTransform = Camera.main.transform;
		SetCountText ();
		
	}
  
   
	void Update ()
	{
        Vector3 movement = Vector3.zero;
         movement.x = Input.GetAxis ("Horizontal");
		 movement.z = Input.GetAxis ("Vertical");
        if (movement.magnitude > 1)
            movement.Normalize();

        
        //Rotate direction of camera vectors
        Vector3 rotatedMov = camTransform.TransformDirection(movement);
        rotatedMov = new Vector3(rotatedMov.x, 0, rotatedMov.z);
        rotatedMov = rotatedMov.normalized * movement.magnitude;
		rb.AddForce (rotatedMov*speed);

        
    }
   
    public void FixedUpdate()
    {
        float hInput = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        float vInput = CrossPlatformInputManager.GetAxis("Vertical")* speed;

        rb.AddForce(hInput, 0, vInput);
        
    }
    public void Drag()
    {
        if (speed >= 7f)
        {
            speed=0f;
        }
    }
    void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Pick Up"))
	{ 
		other.gameObject.SetActive(false);
			count = count +1;
			SetCountText ();
	}
        if (other.gameObject.CompareTag("Bonus Pick"))
        {
            other.gameObject.SetActive(false);
            count = count + 3;
            SetCountText();
        }

    }
	public void SetCountText (){
		countText.text = "Score: " + count.ToString ();
        
		if (count >= winCount) 
		{
      

             
       
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
            

        }
    }
    public void OnDisable()
     {
        
        
         PlayerPrefs.SetFloat("Score", count);
 
         if ((count) > PlayerPrefs.GetFloat ("HighScore")){
 
             PlayerPrefs.SetFloat ("HighScore", count);
         }
     }
 
   void OnGUI ()
     {
       GUI.skin.label.fontSize = 50;

        GUI.color = Color.black;   
         GUI.Label(new Rect(1200, 5, 300, 250), "High Score: " + (int) PlayerPrefs.GetFloat ("HighScore"));
         
     }
     
 
	
	
}


