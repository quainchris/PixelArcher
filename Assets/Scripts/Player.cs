using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	public float speed = 0.1f;
	public float jumpSpeed = 0.1f;
	public Transform groundedEnded;
	public bool grounded = false;
	public GameObject bow;
	Animator anim;
	public bool isPaused = false;
	public float timer = 10f;
	
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}
	
	void Update ()
	{

		Debug.DrawLine(this.transform.position,groundedEnded.position,Color.green);
		grounded = Physics2D.Linecast(this.transform.position, groundedEnded.position, 1<<LayerMask.NameToLayer("Ground"));

		Vector2 dir = Vector2.zero;	

		if (Input.GetKey (KeyCode.D)) {
			anim.SetInteger ("Direction", 1);
			dir.x = speed;			
		} else if 
			(Input.GetKey (KeyCode.A)) {
			anim.SetInteger ("Direction", 2);
			dir.x = -speed;
			bow.transform.rotation = this.transform.rotation;
		} else {	
			anim.SetInteger ("Direction", 0);
		}
		transform.Translate (dir);

		if(Input.GetButton("Jump") && grounded)
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2f), ForceMode2D.Impulse);
		}

//		if(Input.GetKeyDown(KeyCode.P)&& timer >= 10f) 
//		{
//			isPaused = !isPaused;
//		}
//
//		if (isPaused && timer < 10f && timer > 0 && Input.GetKeyDown(KeyCode.P) ) {
//			isPaused = false;
//		}
		if (isPaused)
			timer -= Time.deltaTime;

		if (timer < 0 && isPaused) {
			isPaused = false;
		}

		if(timer < 10f && !isPaused)
			timer += Time.deltaTime;

				
	}

}//end class