using System.Collections;
using UnityEngine;

public abstract class CellComponent
{
    public Cell cell { get; private set; }
    public virtual void Awake(Cell cell)
    {
        this.cell = cell;
    }//初始化
    public virtual void Start()
    {

    }//开始
}