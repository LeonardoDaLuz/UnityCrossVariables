﻿//Um minmax slider, mas que fica readOnly caso seja diferente da variável especificada. Horrível usar isso, corra pro custom inspector que é menos dor de cabeça.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RangeReadOnlyIfDifferent : Hidesbase
{
    public string varName;
    public object ValueToCheck;
    public float min;
    public float max;

    public RangeReadOnlyIfDifferent(float min, float max, string varToCheck, object ValueToCheck)
    {
        this.varName = varToCheck;
        this.ValueToCheck = ValueToCheck;
        this.min = min;
        this.max = max;
    }
}

 