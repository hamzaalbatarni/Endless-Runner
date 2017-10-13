
using UnityEngine;

public class playerfollower : MonoBehaviour {

    public Transform player;
    public Vector3 Offset;
	void Update () {

        transform.position = player.position;
        transform.position = player.position + Offset;
	}
}
