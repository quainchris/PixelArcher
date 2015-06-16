using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
	public float arrowSpeed = 80f;
	float degreesPerSecond = 45;
	private bool isMoving = true;
	public bool isPaused;
	public GameObject player;
	private GameObject target;
	// Update is called once per frame
	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Target");
	}
	
	void Update ()
	{
		isPaused = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().isPaused;

		//if (!isPaused) {
			if (isMoving) {
				this.transform.Translate (Vector2.right * arrowSpeed * Time.deltaTime);
				//this.transform.Rotate (-Vector3.forward, degreesPerSecond * Time.deltaTime);
			}
		//}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Target") {
			target.GetComponent<DefenderXMovement>().isPaused = true;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Ground" || col.tag == "Target" ) {
			GetComponent<Rigidbody2D>().isKinematic = true;
			isMoving = false;
			Destroy (this.gameObject, 10);
		}
	}
}
