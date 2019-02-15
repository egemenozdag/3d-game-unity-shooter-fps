using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class death : MonoBehaviour {
	private int count =0;
	public int enem=0;
    public Text countText;
    public Text winText;
	//public ParticleSystem anim;
    void Start(){}

	void Update () {}
	void OnTriggerEnter(Collider col){
				if(col.gameObject.tag == "bullet"){
						count++; 
						if(count == 5){ 
							Destroy(gameObject);
							enem++;
							SetCountText();
						}
				}
	}
	 void SetCountText (){
        countText.text = "enemy: " + enem.ToString ();
        if (enem >= 10)
        {
            winText.text = "You Win!";
        }
    }
}
