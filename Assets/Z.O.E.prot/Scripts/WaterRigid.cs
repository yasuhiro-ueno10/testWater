using UnityEngine;
using System.Collections;

public class WaterRigid : MonoBehaviour {

	public int WATER_DENSITY = 100;
	public float WATER_FLOAT_FORCE = 20;

	// Call before Start()
	void Awake () {

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		this.rigid (col);
	}
	void OnTriggerStay (Collider col) {
		this.rigid (col);
	}

	void rigid (Collider col) {
		if (col.tag != "Core") {
			return ;
		}

		Transform objT = col.transform;

		float objFoot = objT.position.y - objT.lossyScale.y / 2;
		Transform waterT = this.transform;
		float waterTop = waterT.position.y + waterT.lossyScale.y / 2;

		float inWaterLenge = waterTop - objFoot;
		if (inWaterLenge < 0) {
			return;
		}
		float inWater = inWaterLenge / objT.lossyScale.y;
		float floatForce = WATER_FLOAT_FORCE * inWater;

		Rigidbody rig = col.rigidbody;
		rig.AddForce (new Vector3(0, floatForce, 0));
		rig.velocity = rig.velocity * 0.96f;

	}
}
