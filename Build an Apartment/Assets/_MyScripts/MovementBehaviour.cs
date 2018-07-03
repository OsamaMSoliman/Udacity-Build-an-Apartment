using UnityEngine;

namespace _MyScripts {
    public class MovementBehaviour : MonoBehaviour {
        public float Speed = 5f;

        private Vector3 _startPos;
        private Transform _mainCamTrans;

        private void Start() {
            _mainCamTrans = Camera.main.transform;
            _startPos = transform.position;
        }

        // Update is called once per frame
        void Update() {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            transform.position += (_mainCamTrans.forward * v + _mainCamTrans.right * h) * Time.deltaTime * Speed;
        }

        public void ResetPosition() { transform.position = _startPos; }
    }
}