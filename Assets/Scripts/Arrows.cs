using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class Arrows : MonoBehaviour
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
