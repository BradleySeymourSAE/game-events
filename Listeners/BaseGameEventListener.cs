#region Namespaces
using UnityEngine;
using UnityEngine.Events;
using GameEvents;
#endregion



namespace GameEvents
{
    public abstract class BaseGameEventListener<T, TEvent, TEventResponse> : MonoBehaviour, IEventListener<T>
    where TEvent : BaseGameEvent<T>
    where TEventResponse : UnityEvent<T>
    {
        [SerializeField] private TEvent m_GameEvent;

        public TEvent GameEvent
	    {
            get => m_GameEvent;
            set => m_GameEvent = value;
	    }

        [SerializeField] private TEventResponse m_UnityEventResponse;

        public TEventResponse EventResponse
        {
            get => m_UnityEventResponse;
            set => m_UnityEventResponse = value;
        }

        private void OnEnable() => GameEvent.RegisterListener(this);

        private void OnDisable() => GameEvent.UnregisterListener(this);

        public void RaiseEvent(T _t)
        {
            EventResponse.Invoke(_t);
        }
    }
}