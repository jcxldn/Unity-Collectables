using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
        transform.Rotate(new Vector3(15, 20, 45) * Time.deltaTime);
	}
}
