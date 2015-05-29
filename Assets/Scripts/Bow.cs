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
	
	// Use this for initialization
	void Start ()
	{
		anim = this.GetComponent<Animator> ();	
		transform.Rotate(0, 0, Input.GetAxis("Mouse Y") * 2f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetMouseButtonDown (0)) {	
			isPressed = true;	
			anim.Play ("BowAnim");
			isReleased = false;
		}		

		mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z));

		if (mousePosition.y > lastMousePosition.y) {
			transform.Rotate(0, 0, Input.GetAxis("Mouse Y"));
		}
		if (mousePosition.y < lastMousePosition.y) {
			transform.Rotate(0, 0 , Input.GetAxis("Mouse Y"));
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

		lastMousePosition = mousePosition;
	}
}//end class
