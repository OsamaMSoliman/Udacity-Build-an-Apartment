using UnityEngine;

namespace _MyScripts {
	public class ResetPosition : MonoBehaviour {
		private void OnTriggerExit(Collider other) {
			if (other.CompareTag("Player")) {
				other.GetComponent<MovementBehaviour>().ResetPosition();
			}
		}
	}
}
