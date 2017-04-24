﻿
	using UnityEngine;
	using System.Collections;

	public class don : MonoBehaviour 
	{
		float rotSpeed = 100;

		void OnMouseDrag()
		{
			float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
			float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

			transform.RotateAround(Vector3.up, -rotX);
			transform.RotateAround(Vector3.down, rotY);
		}
	}


