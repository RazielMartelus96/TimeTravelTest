using UnityEngine;

namespace _Scripts.model.TimeTravel
{
    public class TimeJumpableSquare : MonoBehaviour, ITemporalObject
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        void Start()
        { 
            TimeTravelManager.instance.RegisterTemporalObject(this);
        }

        void Update()
        {
        
        }

        public void ExecuteTemporalShift()
        {
            _spriteRenderer.color = Color.green;
        }
    }
}
