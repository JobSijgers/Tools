using UnityEditor;
using UnityEngine;

namespace Mass_Rename
{
    public class MassRename : EditorWindow
    {
        private SerializedObject serializedObject;
        private SerializedProperty objectsToRename;
        public GameObject[] objects;
        private string newName;
        private int startIndex;

        [MenuItem("Window/Mass Rename")]
        public static void ShowWindow()
        {
            GetWindow(typeof(MassRename));
        }

        private void OnEnable()
        {
            serializedObject = new SerializedObject(this);
            objectsToRename = serializedObject.FindProperty("objects");
        }

        private void OnGUI()
        {
            serializedObject.Update();
            //show all field in the inspector
            EditorGUILayout.PropertyField(objectsToRename);
            newName = EditorGUILayout.TextField("New Name", newName);
            startIndex = EditorGUILayout.IntField("Start Index", startIndex);

            if (GUILayout.Button("Rename"))
            {
                Rename();
            }

            serializedObject.ApplyModifiedProperties();
        }

        //renames all objects in the array
        private void Rename()
        {
            //check if the objects array is empty
            if (objects == null || objects.Length == 0)
            {
                Debug.LogWarning("No objects to rename");
                return;
            }
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == null)
                {
                    Debug.LogWarning("Object at index " + i + " is null");
                    return;
                }
                objects[i].name = newName + " " + (i + startIndex);
            }
        }
    }
}