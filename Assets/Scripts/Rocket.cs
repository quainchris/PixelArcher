using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	
	public GameObject player;
	public GameObject rocket;
	Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
			if (coll.gameObject.tag == "Player") {
				Destroy(coll.gameObject);
			}
			else if
		       (coll.gameObject.tag == "Ground") {
		        anim.Play("Impact", -1, 1);
			    Destroy(rocket.gameObject, 0.1f);
		}
			
	}
}
