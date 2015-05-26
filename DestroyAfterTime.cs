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

        /// GO to be destroyed.
        public GameObject Target {
            get { return target; }
            set { target = value; }
        }

        /// Destroy delay.
        public float Delay {
            get { return delay; }
            set { delay = value; }
        }

        // todo extract
        private void Start () {
            if (Target) {
                Destroy(Target, Delay);
            }
            else {
                Utilities.MissingReference(this, "Target");
            }
        }

        public void Now() {
            Destroy(Target);
        }
    }
}
