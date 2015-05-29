using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour 
{
//	public Texture2D cursorImage;
//	
//	private int cursorWidth = 25;
//	private int cursorHeight = 25;
//	public GameObject player;
	
	void Start()
	{
		Cursor.visible = false;
	}
	
	
	void OnGUI()
	{
		//GUI.DrawTexture(new Rect(player.transform.position.x + 100, player.transform.position.y, cursorWidth, cursorHeight), cursorImage);
	}
}