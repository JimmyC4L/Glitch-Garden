using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{

	[SerializeField] private int star = 100;

	private Text _starText;
	
	private void Start()
	{
		_starText = GetComponent<Text>();
		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		_starText.text = star.ToString();
	}

	public void AddStars(int amount)
	{
		star += amount;
		UpdateDisplay();
	}
	
	public void SpendStars(int amount)
	{
		if (star >= amount)
		{
			star -= amount;
			UpdateDisplay();
		}
	}
}
