﻿using UnityEngine;
using System.Collections;

namespace DestroyAfterTimeEx {

    public class DestroyAfterTime : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "DestroyAfterTime";

        #endregion

        #region FIELDS

        /// <summary>
        /// Allows identify component in the scene file when reading it with
        /// text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "DestroyAfterTime";
 
        #endregion

        #region INSPECTOR FIELDS

        /// GO to be destroyed.
        [SerializeField]
        private GameObject targetGO;

        /// Destroy delay.
        [SerializeField]
            private float delay;

        [SerializeField]
        private string description = "Description";
 
        #endregion

        #region PROPERTIES

        /// GO to be destroyed.
        public GameObject TargetGO {
            get { return targetGO; }
            set { targetGO = value; }
        }

        /// Destroy delay.
        public float Delay {
            get { return delay; }
            set { delay = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region UNITY MESSAGES

        // todo extract
        private void Start () {
            if (TargetGO) {
                Destroy(TargetGO, Delay);
            }
            else {
                Utilities.MissingReference(this, "Target");
            }
        }

        #endregion

        #region METHODS

        public void Now() {
            Destroy(TargetGO);
        }

        #endregion
    }
}
