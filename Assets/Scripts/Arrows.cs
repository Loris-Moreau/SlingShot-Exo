using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class Arrows : MonoBehaviour
{
	public Bow bow;

    public int damage;

	private void OnTriggerEnter(Collider other)
	{
		if (CompareTag("Enemy"))
		{
			//Kaboom
			bow.arrowRb.gameObject.SetActive(true);
		}
	}
}
