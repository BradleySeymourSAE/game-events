#region Namespaces
using UnityEngine;
using UnityEngine.Events;
using GameEvents;
#endregion

namespace GameEvents
{
	[System.Serializable] public class UnityTransformEvent : UnityEvent<Transform> { }
}