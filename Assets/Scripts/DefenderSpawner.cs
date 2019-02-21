using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

	private Defender _defender;

	
	private void OnMouseDown()
	{
		SpawnDefender(GetSquareClicked());
	}
	
	private void SpawnDefender(Vector2 gridPosition)
	{
		var newDefender = Instantiate(_defender, gridPosition, Quaternion.identity);
	}

	public void SetSelectedDefender(Defender selectedDefender)
	{
		_defender = selectedDefender;
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
