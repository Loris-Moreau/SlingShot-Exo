using UnityEngine;

public class Sling : MonoBehaviour
{
	public Animator slingAnim;

	float charge; //curent charge
	public float chargeMax; 
	public float chargeSpeed; //rate of the charge (how fast it goes)

	public KeyCode fireButton; //boom boom button (bbb)

	public Transform spawn; //position of the bullet
	public Rigidbody bulletRb; //"blueprint" of the bullet

	private void Start()
	{
		//slingAnim = GetComponent<Animator>();	
	}

	private void Update()
	{
		if(Input.GetKey(fireButton) && charge < chargeMax) //pressing bbb & charge smaller than max charge
		{
			charge += Time.deltaTime * chargeSpeed; //charging up

			Debug.Log(charge.ToString());

			slingAnim.SetBool("Aim", true); //sling shot pull
		}

		if (Input.GetKeyUp(fireButton))
		{
			Rigidbody bullet = Instantiate(bulletRb, spawn.position, Quaternion.identity) as Rigidbody; //make new bullet at bullet spawn, as rigidbody not an object

			bullet.AddForce(spawn.forward * (charge), ForceMode.Impulse); //shoots the bullet forward multiplied by the charge, ///forceMode aply force all at once 

			charge = 0; //reset charge to fire again
			slingAnim.SetBool("Aim", false); //sling shot release
		}
	}
}
