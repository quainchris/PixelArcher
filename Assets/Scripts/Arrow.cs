using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
	public float arrowSpeed = 30f;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.Translate (Vector2.right * arrowSpeed * Time.deltaTime);
	}
}
