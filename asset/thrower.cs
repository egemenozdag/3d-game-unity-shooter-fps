using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrower : MonoBehaviour {
	public Rigidbody bulletPrefab;
	public float throwSpeed = 30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
				Rigidbody newBullet = Instantiate(bulletPrefab,transform.position,transform.rotation) as Rigidbody;
				newBullet.name = "bullet";
				newBullet.velocity = transform.forward * throwSpeed;
		}
		
	}
}
