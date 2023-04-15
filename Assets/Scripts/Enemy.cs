using System;
using System.Runtime.InteropServices;
using UnityEngine;
//why am I like this ?
//aaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhh

public class Enemy : MonoBehaviour
{
	public bool IsEnemyHit;

	public BoxCollider boxCollider;

	public GameObject Skelly;

	public Transform HeadSpawn; //position of the Head
	public Rigidbody HeadRb; //"blueprint" of the Head

	public Transform ChestSpawn; //position of the Chest
	public Rigidbody ChestRb; //"blueprint" of the Chest

	public Transform LegsSpawn; //position of the Legs
	public Rigidbody LegsRb; //"blueprint" of the Legs

	private void Update()
	{
		if (IsEnemyHit)
		{
			SpawnBones();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Bullet"))
		{
			IsEnemyHit = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		IsEnemyHit = false;
	}

	public void SpawnBones()
	{
		if (boxCollider.enabled == true)
		{
			Skelly.SetActive(false);

			Rigidbody head = Instantiate(HeadRb, HeadSpawn.position, Quaternion.identity) as Rigidbody; //head spawn

			Rigidbody chest = Instantiate(ChestRb, ChestSpawn.position, Quaternion.identity) as Rigidbody; //chest spawn

			Rigidbody legs = Instantiate(LegsRb, LegsSpawn.position, Quaternion.identity) as Rigidbody; //legs spawn

			head.AddExplosionForce(100, HeadSpawn.up, 15); 

			chest.AddExplosionForce(150, ChestSpawn.right, 25);

			legs.AddExplosionForce(125, LegsSpawn.forward, 20);

			boxCollider.enabled = false;
		}
	}
}
