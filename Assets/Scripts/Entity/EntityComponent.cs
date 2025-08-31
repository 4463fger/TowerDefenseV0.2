using System.Collections;
using UnityEngine;
using JKFrame;
public abstract class EntityComponent
{
    public float maxHp;
    public abstract void Awake();
    public abstract void Start();
}