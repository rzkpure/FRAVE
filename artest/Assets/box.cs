using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "fire"){

			Destroy(collision.gameObject,2f);
			Destroy(gameObject,1f);
			Debug.Log("hit");
		}

	}
}
