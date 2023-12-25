using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces.Abstract
{
    internal interface IHavingDamage
    {
        int Damage { get; }
        int DamageRange { get; }
    }
}
