using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	public float speed = 0.1f;
	public float jumpSpeed = 0.1f;
	Animator anim;
	
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}
	
	void Update ()
	{
		Vector2 dir = Vector2.zero;	

		if (Input.GetKey (KeyCode.D)) {
			anim.SetInteger ("Direction", 1);
			dir.x = speed;			
		} else if 
			(Input.GetKey (KeyCode.A)) {
			anim.SetInteger ("Direction", 1);
			dir.x = -speed;
		} else {	
			anim.SetInteger ("Direction", 0);
		}
		transform.Translate (dir);
				
	}
	//Attemped to get him jumping
	void OnCollisionStay2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Ground" && (Input.GetKey (KeyCode.Space))) {
	
		}
	}

}//end class