using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace FloatingPoint
{
    /// <summary>
    /// Monobehaviours (scripts) are added to GameObjects.
    /// For a full list of Messages a Monobehaviour can receive from the game, see https://docs.unity3d.com/ScriptReference/MonoBehaviour.html.
    /// </summary>
    public class FloatingPointController : IInitializable
    {
        public void Initialize()
        {
            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
            foreach (object go in allObjects) ;
            Plugin.Log.Debug("Objects Set to variable.");
            foreach(GameObject obj in allObjects)
            {
                obj.transform.position += new Vector3(0, 1, 0);
            }
        }
       
        public static FloatingPointController Instance { get; private set; }

        
        /// <summary>
        /// Called when the script becomes enabled and active
        /// </summary>
        private void OnEnable()
        {

        }

        /// <summary>
        /// Called when the script becomes disabled or when it is being destroyed.
        /// </summary>
        private void OnDisable()
        {

        }
    }
}
