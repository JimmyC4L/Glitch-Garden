﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

	[SerializeField] private float health = 100f;
	[SerializeField] private GameObject deathVFX;

	public void DealDamage(float damage)
	{
		health -= damage;
		if (health <= 0)
		{
			TriggerDeathVFX();
			Destroy(gameObject);
		}
	}

	private void TriggerDeathVFX()
	{
		if (!deathVFX)
		{
			return;
		}

		var deathVfxObj = Instantiate(deathVFX, transform.position, Quaternion.identity);
		Destroy(deathVfxObj, 1f);
	}
}
