using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {


	// Call before Start()
	void Awake () {
		DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
