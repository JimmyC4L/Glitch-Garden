using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

	[SerializeField] private GameObject defender;

	private void SpawnDefender(Vector2 gridPosition)
	{
		var newDefender = Instantiate(defender, gridPosition, Quaternion.identity);
	}

	private void OnMouseDown()
	{
		SpawnDefender(GetSquareClicked());
	}

	private Vector2 GetSquareClicked()
	{
		var clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		var worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
		var gridPosition = SnapToGrid(worldPosition);
		return gridPosition;
	}

	private Vector2 SnapToGrid(Vector2 rawWorldPosition)
	{
		var newX = Mathf.RoundToInt(rawWorldPosition.x);
		var newY = Mathf.RoundToInt(rawWorldPosition.y);
		return new Vector2(newX,newY);
	}
}
