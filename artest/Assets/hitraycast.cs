using UnityEngine;
using System.Collections;

public class hitraycast : MonoBehaviour {
	Ray ray;
	RaycastHit objectHit;
	//public static GameObject target1;
	public static string enemy;
	// Use this for initialization
	void Start ()
	{
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);


	}
	
	// Update is called once per frame
	void Update () {

		if (Physics.Raycast(transform.position, transform.forward, out objectHit, 1000)) {
			//Debug.Log("Raycast hitted to: " + objectHit.collider);
			Debug.Log(objectHit.collider.name);
			enemy = objectHit.collider.name;


			Debug.Log("Enemy : "+ enemy);
		

		}

			
}
}