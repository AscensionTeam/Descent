using Entitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    /// <summary>
    /// Input Controller Class.
    /// </summary>
    public class InputController : MonoBehaviour
    {
        Vector3 lastframemouse;

        void Start()
        {
            lastframemouse = Input.mousePosition;
        }

        void Update()
        {
            if (Input.anyKey)
            {
                if (!string.IsNullOrEmpty(Input.inputString))
                {
                    Pools.sharedInstance.occurrence.CreateEntity().AddOccurrence(0, "System.Input.Key", new object[] { Input.inputString });
                }
            }

            if (lastframemouse != Input.mousePosition)
            {
                Pools.sharedInstance.occurrence.CreateEntity().AddOccurrence(0, "System.Input.MouseMove", new object[] { Input.mousePosition });
            }

           lastframemouse = Input.mousePosition;
        }
    }
}
