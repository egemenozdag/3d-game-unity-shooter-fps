using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour {

	void OnTriggerEnter(Collider col){
				if(col.gameObject.tag == "Player"){
					win();	
				}
	}
	void win(){
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}

}
