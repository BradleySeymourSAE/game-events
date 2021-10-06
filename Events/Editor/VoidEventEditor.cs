#region Namespaces
using UnityEngine;
using UnityEditor;
using GameEvents;
#endregion

namespace GameEvents
{
	[CustomEditor(typeof(VoidEvent))]
	public class VoidEventEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			VoidEvent l_VoidEventEditor = (VoidEvent)target;

			if (GUILayout.Button("Raise()"))
			{
				l_VoidEventEditor.Raise();
			}
		}
	}
}