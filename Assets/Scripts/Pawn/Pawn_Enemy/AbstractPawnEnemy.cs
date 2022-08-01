using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AbstractPawnEnemy : Pawn
{
    [Header("Enemy Attributes")]

    // pattern of the pawn
    public Pattern pattern;

    // trigger
    public Trigger trigger;
}