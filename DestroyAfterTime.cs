using UnityEngine;
using System.Collections;

namespace DestroyAfterTimeEx {

    public class DestroyAfterTime : MonoBehaviour {

        #region INSPECTOR FIELDS

        /// GO to be destroyed.
        [SerializeField]
        private GameObject target;

        /// Destroy delay.
        [SerializeField]
            private float delay;

        #endregion

        #region PROPERTIES

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

        #endregion

        #region UNITY MESSAGES

        // todo extract
        private void Start () {
            if (Target) {
                Destroy(Target, Delay);
            }
            else {
                Utilities.MissingReference(this, "Target");
            }
        }

        #endregion

        #region METHODS

        public void Now() {
            Destroy(Target);
        }

        #endregion
    }
}
