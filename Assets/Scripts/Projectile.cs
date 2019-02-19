using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{

	[SerializeField] private float speed = 2f;
	[SerializeField] private float damage = 50f;
	
	private void Update()
	{
		transform.Translate(Vector2.right* speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D otherCollider2D)
	{
		var health = otherCollider2D.GetComponent<Health>();
		var attacker = otherCollider2D.GetComponent<Attacker>();

		if (attacker && health)
		{
			health.DealDamage(damage);
			Destroy(gameObject);
		}
	}
}
