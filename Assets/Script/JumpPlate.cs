using UnityEngine;
using System.Collections;

public class JumpPlate : MonoBehaviour {
    public float power = 10;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rigid = collision.gameObject.GetComponent<Rigidbody>();
            rigid.AddForce(0, this.power, 0);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
