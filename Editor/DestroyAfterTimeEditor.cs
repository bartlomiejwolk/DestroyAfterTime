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

        private SerializedProperty description;

        #endregion SERIALIZED PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();
            
            serializedObject.ApplyModifiedProperties();
        }

        private void OnEnable() {
            Script = (DestroyAfterTime) target;
            
            description = serializedObject.FindProperty("description");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS
        
        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    DestroyAfterTime.Version,
                    DestroyAfterTime.Extension));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }

        #endregion INSPECTOR

        #region METHODS

        [MenuItem("Component/DestroyAfterTime")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof (DestroyAfterTime));
            }
        }

        #endregion METHODS
    }

}