using UnityEngine;
using System.Collections;

public class Bow : MonoBehaviour
{
	
	public Animator anim;
	public bool isPressed = false;
	public bool isReleased = false;
	public GameObject arrow;
	
	// Use this for initialization
	void Start ()
	{
		anim = this.GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetMouseButtonDown (0)) {	
			isPressed = true;	
			anim.Play ("BowAnim");
		
		}		
	
		if (Input.GetMouseButtonUp (0)) {	
			isReleased = true;
			isPressed = false;	
			anim.Play ("BowReleasedAnim");
			Instantiate (arrow, this.transform.position, Quaternion.identity);	
		}	
	}
}//end class
