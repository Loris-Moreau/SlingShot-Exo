using System;
using UnityEngine;
//why am I like this ?
//aaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhh

public class Enemy : MonoBehaviour
{
	public bool IsEnemyHit;

	public Bullets bullet;

	public Transform HeadSpawn; //position of the head
	public Rigidbody HeadRb; //"blueprint" of the head

	public Transform LegsSpawn; //position of the legs
	public Rigidbody LegsRb; //"blueprint" of the legs

	private void Update()
	{
		if (bullet.IsEnemyHit)
		{
			SpawnBones();
		}
	}

	public void SpawnBones()
	{
		Rigidbody head = Instantiate(HeadRb, HeadSpawn.position, Quaternion.identity) as Rigidbody; //make new head at head spawn, as rigidbody not an object

		Rigidbody legs = Instantiate(LegsRb, LegsSpawn.position, Quaternion.identity) as Rigidbody; //make new legs at legs spawn, as rigidbody not an object
	}
}
