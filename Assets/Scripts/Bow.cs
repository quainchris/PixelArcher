using UnityEngine;
using System.Collections;

public class Bow : MonoBehaviour
{
	
	public Animator anim;
	public bool isPressed = false;
	public bool isReleased = false;
	public GameObject arrow;
	public float timer = 0.14f;
	private Vector3 mousePosition;
	private Vector3 lastMousePosition;
	public float lastVerticalPosition;
	public float speed = 2.0f;
	public float zRotation;
	
	// Use this for initialization
	void Start ()
	{
		anim = this.GetComponent<Animator> ();	
		//transform.Rotate(0, 0, Input.GetAxis("Mouse Y") * 2f);
	}
	
	// Update is called once per frame
	void Update ()
	{

		float vertical = Input.GetAxis ("Vertical") * speed;

		if (Input.GetMouseButtonDown (0)) {	
			isPressed = true;	
			anim.Play ("BowAnim");
			isReleased = false;
		}	
//		mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z));
//
//		if (mousePosition.y > lastMousePosition.y) {
//			transform.Rotate(0, 0, Input.GetAxis("Mouse Y"));
//		}
//		if (mousePosition.y < lastMousePosition.y) {
//			transform.Rotate(0, 0 , Input.GetAxis("Mouse Y"));
//		}


		//Rotates the bow according to the W and S keys
		if (Input.GetKey(KeyCode.W)){
			transform.Rotate(0, 0, vertical);
		}
		if (Input.GetKey(KeyCode.S)){
			transform.Rotate(0, 0, vertical);
		}

		if (Input.GetMouseButtonUp (0) && timer <= 0) 
		{	
			isReleased = true;
			isPressed = false;	
			anim.Play ("BowReleasedAnim");
			Instantiate (arrow, this.transform.position, this.transform.rotation);
			timer = 0.14f;
		}	

		if (isPressed) {
			timer -= Time.deltaTime;
		}

		//Clamps the rotation between -90 degrees and +90 degrees
		Quaternion rotate = this.transform.rotation;
		rotate.z = Mathf.Clamp (rotate.z, -0.7f, 0.7f);
		transform.localRotation = rotate;

	}
}//end class
