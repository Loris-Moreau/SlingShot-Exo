using System;
using System.Runtime.InteropServices;
using UnityEngine;

//why am I like this ?
//aaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhh

public class Enemy : MonoBehaviour
{
	public bool IsEnemyHit;

	public AudioClip ScorePing;

	public BoxCollider boxCollider;

	public GameObject Skelly;

	public Transform HeadSpawn; //position of the Head
	public Rigidbody HeadRb; //"blueprint" of the Head

	public Transform ChestSpawn; //position of the Chest
	public Rigidbody ChestRb; //"blueprint" of the Chest

	public Transform LegsSpawn; //position of the Legs
	public Rigidbody LegsRb; //"blueprint" of the Legs

	public int hitCounter; //to know how many times you hit an enemy

	/*public GameObject score1;
	public GameObject score2;*/

	private void Start()
	{
		hitCounter = 0;

		/*score1.SetActive(false);
		score2.SetActive(false);*/
	}

	private void Update()
	{
		/*if (hitCounter==1)
		{
			score1.SetActive(true);
		}*/
		if (hitCounter >= 2) 
		{
			//score2.SetActive(true);

			SpawnBones();

			hitCounter = 0;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Bullet"))
		{
			IsEnemyHit = true;

			hitCounter++;

			AudioSource.PlayClipAtPoint(ScorePing, transform.position);

			Rewards.CurrentScore += 50;
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
