using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class bullettran : MonoBehaviour {

	float bulletspeed =  35f;
	//Transform target1;

	// Use this for initialization

	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {


		//transform.position = Vector3.MoveTowards(transform.position,target1.position,  bulletspeed*Time.deltaTime);


		//transform.localPosition = Vector3.Lerp (transform.localPosition,target1.localPosition,3f*Time.deltaTime);
		//transform.localRotation = Quaternion.Lerp (transform.localRotation, target1.localRotation, 3f * Time.deltaTime);
//
	transform.localPosition += transform.forward * bulletspeed * Time.deltaTime;
	Destroy (gameObject, 10f);
	

		//Debug.Log (target1);
	}
}
