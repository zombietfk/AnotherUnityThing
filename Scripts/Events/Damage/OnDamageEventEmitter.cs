﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class OnDamageEventEmitter : MonoBehaviour {

    [SerializeField]
    private OnDamageEventHandler Handler;

    public void Emit(OnDamageRecievedEventData e){
        Handler.OnReceiveDamage.Invoke(e);
    }
}
