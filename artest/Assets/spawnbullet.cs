using UnityEngine;
using System.Collections;

public class spawnbullet : MonoBehaviour
{
	public GameObject shoot;


	// Use this for initializatio
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}


	public void fightbullet()
	{



		Instantiate(shoot, Vector3.forward, Quaternion.identity);


	}

	}

