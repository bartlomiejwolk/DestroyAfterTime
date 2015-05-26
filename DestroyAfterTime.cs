using UnityEngine;
using System.Collections;

namespace DestroyAfterTimeEx {

    public class DestroyAfterTime : MonoBehaviour {

        /// GO to be destroyed.
        [SerializeField]
        private GameObject target;

        /// Destroy delay.
        [SerializeField]
            private float delay;

        private void Start () {
            if (target) {
                Destroy(target, delay);
            }
            else {
                Utilities.MissingReference(this, "Target");
            }
        }

        public void Now() {
            Destroy(target);
        }
    }
}
