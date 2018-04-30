﻿using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface IComponentRepository
    {
        void Register(IEntity entity, IComponent component);
        void Unregister(IEntity entity, IComponent component);
        IReadOnlyCollection<IComponent> GetComponents(IEntity entity);
        T GetComponent<T>(IEntity entity) where T : IComponent;
    }
}
