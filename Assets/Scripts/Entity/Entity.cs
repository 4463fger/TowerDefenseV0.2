using Assets.Scripts.Entity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity
{
    public int maxHp;
    public Vector2Int coord;
    public EntityConfig entityConfig;
    public List<EntityComponent> components = new List<EntityComponent>();
    public virtual void Awake()
    {

    }
    public virtual void Start()
    {

    }
    public void TryGetComponent<T>(out T component) where T : EntityComponent
    {
        foreach (var comp in components)
        {
            if (comp is T)
            {
                component = (T)comp;
                return;
            }
        }
        component = null;
    }//尝试获取实体单位的组件
    public void AddComponent(EntityComponent component)
    {
        components.Add(component);
    }//添加实体单位的组件
}
