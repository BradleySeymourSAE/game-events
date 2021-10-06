#region Namespaces
using UnityEngine;
using GameEvents;
#endregion


namespace GameEvents
{
	[CreateAssetMenu(fileName = "New Transform Event", menuName = "Game Events/Transform")]
	public class TransformEvent : BaseGameEvent<Transform> { }
}