#region Namespaces
using UnityEngine;
using GameEvents;
#endregion


namespace GameEvents
{
	public interface IEventListener<T>
	{ 
		void RaiseEvent(T parameter); 
	}
}
