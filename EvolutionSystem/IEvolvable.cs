using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDepths.EvolutionSystem
{
    public interface IEvolvable
    {
        void ApplyEvolution(EvolutionType evolution);
        EvolutionType CurrentEvolution { get; }
    }

    public struct EvolutionData
    {
        string TextureName;
        Rectangle ColliderData;
    }

    public enum EvolutionType
    {
        FruitFly,
        Termite,
        Ant
        // Many more evolutions to go here in future.
    }
}
