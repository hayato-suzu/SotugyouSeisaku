using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
	[Range(0.0f, 15.0f)]
	public float TimeToHide = 5.0f;

	Vector2 previousMousePosition;
	Vector2 currentMousePosition;

	float timeMousePositionStatic = 0.0f;

	void Start()
	{

		Vector3 mp = Input.mousePosition;
		previousMousePosition = currentMousePosition = new Vector2(mp.x, mp.y);

	}

	void Update()
	{

		Vector3 mp = Input.mousePosition;
		currentMousePosition = new Vector2(mp.x, mp.y);

		if (previousMousePosition == currentMousePosition)
		{
			timeMousePositionStatic += Time.deltaTime;
		}
		else
		{
			timeMousePositionStatic = 0.0f;
		}

		if (timeMousePositionStatic > TimeToHide)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}

		previousMousePosition = currentMousePosition;
	}
}
