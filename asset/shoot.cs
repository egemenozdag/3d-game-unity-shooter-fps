using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public Rigidbody bulletPrefab;
	public float throwSpeed = 30.0f;
	public static bool canThrow = false ;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0)){
				Rigidbody newBullet = Instantiate(bulletPrefab,transform.position, transform.rotation) as Rigidbody ;
				newBullet.name = "bullet";
				newBullet.velocity = transform.forward * throwSpeed;
		}
	}
}
