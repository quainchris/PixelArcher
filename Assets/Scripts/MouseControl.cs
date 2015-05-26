using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour 
{
	public Texture2D cursorImage;
	
	private int cursorWidth = 25;
	private int cursorHeight = 25;
	
	void Start()
	{
		Cursor.visible = false;
	}
	
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
	}
}