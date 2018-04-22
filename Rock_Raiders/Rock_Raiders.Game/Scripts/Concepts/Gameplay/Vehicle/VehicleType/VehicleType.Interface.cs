using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock_Raiders.Scripts.Concepts.Gameplay.Shared;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Vehicle.VehicleType
{
    public interface IVehicleType :  ISelectable, ITooltipInformationDisplayable, IExpensive, ITakeTimeToCreateable, IDamageable, IRepairable, IUpgradable, IMoveable, IPilotable
    {

    }

    public interface IPilotable
    {
        int Capacity { get; set; }

    }

    public interface ILightVehicleType : IVehicleType
    {

    }

    public interface IHeavyVehicleType : IVehicleType
    {

    }

    public interface IVehicleTypeGround : IVehicleType
    {

    }

    public interface IVehicleTypeAir : IVehicleType
    {

    }

    public interface IVehicleTypeWater : IVehicleType
    {

    }

    public interface ICanCarryVehicle
    {

    }
}
