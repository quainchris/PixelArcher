using UnityEngine;
using System.Collections;

public class DefenderXAttack : MonoBehaviour {

	public GameObject rocket;
	private float rocketSpeed = 6.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
		
			if (hit.collider.tag == "Player") {
			Instantiate (rocket, this.transform.position, this.transform.rotation);
			rocket.transform.Translate(-Vector2.up * rocketSpeed * Time.deltaTime);
			}
	
	}
}
