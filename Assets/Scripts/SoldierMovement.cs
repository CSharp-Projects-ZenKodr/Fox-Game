using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMovement : MonoBehaviour
{

	public CharacterController2D controller;
	
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			//animator.SetBool("isJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

	}
	public void onLanding()
	{
		//animator.SetBool("isJumping", false);
	}
	public void onCrouching(bool isCrouching)
	{
		//animator.SetBool("isCrouching", isCrouching);
	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
