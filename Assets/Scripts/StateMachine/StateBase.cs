﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase<T>
{
    public virtual void OnEnter(T entity) { }
    public virtual void OnExit(T entity) { }

    public abstract void Update(T entity);
}
