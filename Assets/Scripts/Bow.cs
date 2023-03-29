using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
	public Animator slingAnim;
	float charge; //curent charge
	public float chargeMax; 
	public float chargeSpeed; //rate of the charge (how fast it goes)

	public KeyCode fireButton; //boom boom button

	public Transform spawn; //position of the arrow
	public Rigidbody arrowRb; //"blueprint" of the arrow

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
			Rigidbody arrow = Instantiate(arrowRb, spawn.position, Quaternion.identity) as Rigidbody; //make new arrow at arrow spawn, as rigidbody not an object
			arrow.AddForce(spawn.forward * charge, ForceMode.Impulse); //shoots the arrow forward multiplied by the charge, ///forceMode aply force all at once 
			charge = 0; //reset charge to fire again
			slingAnim.SetBool("Aim", false); //sling shot release
		}
	}
}
