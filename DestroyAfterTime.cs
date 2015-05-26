using UnityEngine;
using System.Collections;

namespace OneDayGame {
	public class DestroyAfterTime : GameComponent {

		/// GO to be destroyed.
		[SerializeField]
			private GameObject _target;

		/// Destroy delay.
		[SerializeField]
			private float _delay;

		public override void Start () {
			base.Start();

			if (_target) {
				Destroy(_target, _delay);
			}
			else {
				MissingReference("_target");
			}
		}

	    public void Now() {
	        Destroy(_target);
	    }
	}
}
