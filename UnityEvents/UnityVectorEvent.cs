#region Namespaces
using UnityEngine;
using UnityEngine.Events;
using GameEvents;
#endregion

namespace GameEvents
{
	[System.Serializable] public class UnityVectorEvent : UnityEvent<Vector3> { }
}