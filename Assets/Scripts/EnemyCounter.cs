using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
	public Rewards rewards;
    public int counter = 0;

	private void Start()
	{
		counter = 4;
	}

	private void Update()
	{
		if(counter == 0) 
		{
			counter--;
		}
		if (counter < 0)
		{
			rewards.WinText.SetActive(true);
		}
	}
}
