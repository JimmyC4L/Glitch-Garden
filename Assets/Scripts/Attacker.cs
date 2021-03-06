﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
	[Range(0f, 5f)] private float _currentSpeed = 1f;	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.left * Time.deltaTime * _currentSpeed);
	}

	public void SetMovementSpeed(float speed)
	{
		_currentSpeed = speed;
	}
}
