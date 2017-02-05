using System;
using VRage.Game.ModAPI.Interfaces;

namespace VRage.Game.ModAPI
{
    public interface IMyEntityController
    {
        IMyPlayer Player { get; }
        IMyControllableEntity ControlledEntity { get; }
        void TakeControl(IMyControllableEntity entity);
        event Action<IMyControllableEntity, IMyControllableEntity> ControlledEntityChanged;
    }
}
