using UnityEngine;
using System.Collections;

public class DefenderXMovement : MonoBehaviour {
	private Vector3 hover = Vector3.left * 0.1f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x > 20)
			hover = Vector3.left * 0.1f;
			
		else if (this.transform.position.x < -20)
			hover = Vector3.right * 0.1f;
		
		transform.Translate(hover);
	}
	
	
}
