using UnityEngine;

public class Bullets : MonoBehaviour
{
	public Enemy enemy;

	public GameObject boom;
	public GameObject boomS;

    public int damage;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
		{
			enemy.IsEnemyHit = true;

			boomS.SetActive(true); //boom
			boom.SetActive(true); //Kaboom
		}
	}
}
