using System;
using System.Runtime.InteropServices;
using UnityEngine;
//why am I like this ?
//aaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhh

public class Enemy : MonoBehaviour
{
	public bool IsEnemyHit;

	//public Bullets bullet;
	public Sling sling;

	public BoxCollider boxCollider;

	public GameObject Skelly;

	public Transform HeadSpawn; //position of the head
	public Rigidbody HeadRb; //"blueprint" of the head

	public Transform LegsSpawn; //position of the legs
	public Rigidbody LegsRb; //"blueprint" of the legs

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

			Rigidbody head = Instantiate(HeadRb, HeadSpawn.position, Quaternion.identity) as Rigidbody;

			Rigidbody legs = Instantiate(LegsRb, LegsSpawn.position, Quaternion.identity) as Rigidbody;

			head.AddForce(HeadSpawn.right * (Sling.Instance.charge), ForceMode.Impulse);

			legs.AddForce(LegsSpawn.right * (Sling.Instance.charge), ForceMode.Impulse);

			boxCollider.enabled = false;
		}
	}
}
