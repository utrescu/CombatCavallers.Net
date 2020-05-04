﻿using CombatCavallers.Lluitador;

namespace CombatCavallers.Combat
{
    /// <summary>
    /// Estructura per anar radiant com va el combat entre
    /// dos lluitadors
    /// </summary>
    interface ICombatents : IResultat
    {
        ILluitador Lluitador { get; }

        /// <summary>
        /// Treu vida a un combatent
        /// </summary>
        /// <returns>Vida que li queda al combatent</returns>
        int TreuVida();
    }
}
