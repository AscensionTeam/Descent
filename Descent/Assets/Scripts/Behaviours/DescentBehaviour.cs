using UnityEngine;
using Entitas;
using System;

public class DescentBehaviour : MonoBehaviour {

    private Entity _Entity = null;
    private Pool _Pool = null;
    private bool _Initialize = false;

    public Entity Entity
    {
        get { return _Entity; }
    }

    public Pool Pool
    {
        get { return _Pool; }
    }


    public void Initialize(Entity Entity, Pool Pool)
    {
        if(_Entity == null)
        {
            _Entity = Entity;
            _Pool = Pool;
            _Initialize = true;
        }
        else
        {
            throw new Exception("You can not Initialize an EntityBehaviour twice.");
        }
    }

    void Update()
    {
        if (_Initialize)
        {
            if (OnInitialize != null) {
                OnInitialize.Invoke(Entity, Pool);
            }

            _Initialize = false;
        }
    }

    public event Action<Entity, Pool> OnInitialize;
}
