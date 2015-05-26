// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the DestroyAfterTime extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEngine;

namespace DestroyAfterTimeEx {

    public class DestroyAfterTime : MonoBehaviour {
        #region CONSTANTS

        public const string Extension = "DestroyAfterTime";
        public const string Version = "v0.1.0";

        #endregion CONSTANTS

        #region FIELDS

        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "DestroyAfterTime";

        #endregion FIELDS

        #region INSPECTOR FIELDS

        /// Destroy delay.
        [SerializeField]
        private float delay;

        [SerializeField]
        private string description = "Description";

        /// GO to be destroyed.
        [SerializeField]
        private GameObject targetGO;

        #endregion INSPECTOR FIELDS

        #region PROPERTIES

        /// Destroy delay.
        public float Delay {
            get { return delay; }
            set { delay = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        /// GO to be destroyed.
        public GameObject TargetGO {
            get { return targetGO; }
            set { targetGO = value; }
        }

        #endregion PROPERTIES

        #region UNITY MESSAGES

        // todo extract
        private void Start() {
            if (TargetGO) {
                Destroy(TargetGO, Delay);
            }
            else {
                Utilities.MissingReference(this, "Target");
            }
        }

        #endregion UNITY MESSAGES

        #region METHODS

        public void Now() {
            Destroy(TargetGO);
        }

        #endregion METHODS
    }

}