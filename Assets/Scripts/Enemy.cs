using UnityEngine;
//why am I like this ?
//aaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhh

public class Enemy : MonoBehaviour
{
	public bool IsEnemyHit;

	private void Start()
	{
		IsEnemyHit = false;
	}

	private void Update()
	{
		if (IsEnemyHit)
		{
			//if enemy gets hit = Kaboom
		}
	}
}
