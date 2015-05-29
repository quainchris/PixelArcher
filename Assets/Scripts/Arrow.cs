using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
	public float arrowSpeed = 80f;
	float degreesPerSecond = 45;
	private bool isMoving = true;

	// Update is called once per frame
	void Update ()
	{
		if (isMoving) {
			this.transform.Translate (Vector2.right * arrowSpeed * Time.deltaTime);
			this.transform.Rotate (-Vector3.forward, degreesPerSecond * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Ground" || col.tag == "Target" ) {
			GetComponent<Rigidbody2D>().isKinematic = true;
			isMoving = false;
			Destroy (this.gameObject, 20);
		}
	}
}
