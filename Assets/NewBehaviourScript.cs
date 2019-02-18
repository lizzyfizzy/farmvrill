using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
