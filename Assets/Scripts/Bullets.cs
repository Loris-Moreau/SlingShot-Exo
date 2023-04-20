using UnityEngine;

public class Bullets : MonoBehaviour
{
	public GameObject boom;
	public GameObject boomS;

	public AudioClip Explosion;

    public int damage;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
		{
			boomS.SetActive(true); //boom
			boom.SetActive(true); //SpawnBones

			AudioSource.PlayClipAtPoint(Explosion, transform.position);
		}
	}
}
