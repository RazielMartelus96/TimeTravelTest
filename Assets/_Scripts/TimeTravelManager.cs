using System.Collections.Generic;
using _Scripts.model.TimeTravel;
using UnityEngine;

namespace _Scripts
{
    public class TimeTravelManager : MonoBehaviour
    {
        public static TimeTravelManager instance { get; protected set; }
        private List<ITemporalObject> _temporalObjects;

        void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(this);
                throw new System.Exception("An instance of the Time Travel Manager already exists.");
            }
            else
            {
                instance = this;
                this._temporalObjects = new List<ITemporalObject>();
            }
        }

        public void RegisterTemporalObject(ITemporalObject objectToRegister)
        {
            this._temporalObjects.Add(objectToRegister);
        }

        public void UnRegisterTemporalObject(ITemporalObject temporalObject)
        {
            this._temporalObjects.Remove(temporalObject);
        }

        public void TimeJump()
        {
            foreach (var temporalObject in this._temporalObjects)
            {
                temporalObject.ExecuteTemporalShift();
            }
        }
       

     
    }
}
