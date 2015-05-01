using UnityEngine;
using System.Collections;

public class cameracontroller : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after all other transforms have run.
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
