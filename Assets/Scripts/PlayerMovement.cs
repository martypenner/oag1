using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public Transform planet;
	public float speed = 25f;
//	public float rotateSpeed = 45f;

	void FixedUpdate ()
	{
		float horz = -Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");

		transform.RotateAround (planet.position, transform.right, speed * Time.deltaTime * vert);
//		transform.Rotate (0f, rotateSpeed * Time.deltaTime * horz, 0f);
		transform.RotateAround (planet.position, transform.forward, speed * Time.deltaTime * horz);
	}
}
