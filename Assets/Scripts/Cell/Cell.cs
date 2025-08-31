using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Cell
{
    public Vector2Int coord;//地块坐标
    public CellType type;//地块类型
    public List<CellComponent> components = new List<CellComponent>();//地块组件
    public Cell DeepCopy()
    {
        Cell cell = new Cell();
        cell.coord = new Vector2Int(this.coord.x, this.coord.y);
        cell.type = this.type;
        return cell;
    }//地块的深拷贝
    public virtual void Awake(Vector2Int coord)
    {
        this.coord = coord;
        for(int i = 0; i < components.Count; i++)
        {
            components[i].Awake(this);
        }
    }//地块的初始化
    public virtual void Start()
    {
        for (int i = 0; i < components.Count; i++)
        {
            components[i].Start();
        }
    }//地块的开始
}
