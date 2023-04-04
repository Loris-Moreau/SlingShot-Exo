using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
	public GameObject boom;
	public GameObject boomS;

    public int damage;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
		{
			boomS.SetActive(true);
			boom.SetActive(true); //Kaboom
		}
	}
}
