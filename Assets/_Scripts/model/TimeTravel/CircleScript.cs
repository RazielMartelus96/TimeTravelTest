using UnityEngine;

namespace _Scripts.model.TimeTravel
{
    public class CircleScript : MonoBehaviour, ITemporalObject
    {
        void Start()
        {
            TimeTravelManager.instance.RegisterTemporalObject(this);
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void ExecuteTemporalShift()
        {
            transform.localScale = new Vector3(3, 3, 3);
        }
    }
}
