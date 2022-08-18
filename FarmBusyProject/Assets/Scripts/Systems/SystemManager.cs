using System.Collections.Generic;
using Unity.VisualScripting;

namespace Systems
{
    public class SystemManager : ISystem
    {
        private List<ISystem> _systems = new List<ISystem>();
        private List<ISystem> _removeSystems = new List<ISystem>();

        public void Add(ISystem system) => _systems.Add(system);

        public void Remove(ISystem system) => _removeSystems.Add(system);

        public void Update(float deltaTime)
        {
            if (_systems.Count < 0)
                return;
            foreach (var system in _removeSystems)
            {
                if (_systems.Contains(system))
                {
                    _systems.Remove(system);
                }
            }
            _removeSystems.Clear();
            foreach (var system in _systems)
            {
                system.Update(deltaTime);
            }
        }
    }
}