using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DarkDepths.InputSystem
{
    public interface IInput
    {
        Vector2 MovementDirection { get; }
        bool Pause { get; }

        void Update();
    }
}
