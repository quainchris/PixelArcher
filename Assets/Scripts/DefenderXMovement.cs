using UnityEngine;
using System.Collections;

public class DefenderXMovement : MonoBehaviour {
	private Vector3 hover = Vector3.left * 0.1f;
	public bool isPaused = false;
	public GameObject player;
	public float timer = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//isPaused = player.GetComponent<Player> ().isPaused;

		if (!isPaused) {
			if (this.transform.position.x > 20)
				hover = Vector3.left * 0.1f;
			else if (this.transform.position.x < -20)
				hover = Vector3.right * 0.1f;
		
			transform.Translate (hover);
		}

		if (isPaused)
			timer -= Time.deltaTime;
		
		if (timer < 0 && isPaused) {
			isPaused = false;
		}
		
		if(timer < 10f && !isPaused)
			timer += Time.deltaTime;
	}
	
	
}
