#region Namespaces
using UnityEngine;
using GameEvents;
#endregion


namespace GameEvents
{
	[CreateAssetMenu(fileName = "New Vector Event", menuName = "Game Events/Vector 3")]
	public class Vector3Event : BaseGameEvent<Vector3> { }
}