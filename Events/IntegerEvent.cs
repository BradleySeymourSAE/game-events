#region Namespaces
using UnityEngine;
using GameEvents;
#endregion


namespace GameEvents
{
	[CreateAssetMenu(fileName = "New Integer Event", menuName = "Game Events/Integer Event")]
	public class IntegerEvent : BaseGameEvent<int>{ }
}