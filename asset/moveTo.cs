using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class moveTo : MonoBehaviour {

	public Transform goal;
	NavMeshAgent agent;
	public Animator myAnim;
	
	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(goal);
		agent.destination = goal.position;
	}
	/**void OnTriggerEnter(Collider col){
				col = GetComponentInChildren(typeof(BoxCollider));
				if(col.gameObject.tag == "enemy"){
					
				}
	} */
	
}
