using UnityEditor;
using UnityEngine;

namespace DestroyAfterTimeEx {

    [CustomEditor(typeof (DestroyAfterTime))]
    [CanEditMultipleObjects]
    public sealed class DestroyAfterTimeEditor : Editor {
        #region FIELDS

        private DestroyAfterTime Script { get; set; }

        #endregion FIELDS

        #region SERIALIZED PROPERTIES

        private SerializedProperty delay;
        private SerializedProperty description;
        private SerializedProperty targetGO;

        #endregion SERIALIZED PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            DrawTargetGOField();
            DrawDelayField();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnEnable() {
            Script = (DestroyAfterTime) target;

            description = serializedObject.FindProperty("description");
            targetGO = serializedObject.FindProperty("targetGO");
            delay = serializedObject.FindProperty("delay");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS

        private void DrawDelayField() {
            EditorGUILayout.PropertyField(
                delay,
                new GUIContent(
                    "Delay",
                    "Delay before destroying the game object."));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }

        private void DrawTargetGOField() {
            EditorGUILayout.PropertyField(
                targetGO,
                new GUIContent(
                    "Target",
                    "Game object to be destroyed."));
        }

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    DestroyAfterTime.Version,
                    DestroyAfterTime.Extension));
        }

        #endregion INSPECTOR CONTROLS

        #region METHODS

        [MenuItem("Component/DestroyAfterTime")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(
                    typeof (DestroyAfterTime));
            }
        }

        #endregion METHODS
    }

}