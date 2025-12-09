using System.Collections.Generic;


namespace DarkDepths.EvolutionSystem
{
    public class EvolutionManager
    {
        List<IEvolvable> _evolvableEntities;

        public EvolutionManager(Game1 game)
        {

        }

        public void AddEntity(IEvolvable entity)
        {
            _evolvableEntities.Add(entity);
        }
    }
}
