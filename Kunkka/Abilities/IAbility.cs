﻿namespace Kunkka.Abilities
{
    using Ensage;

    internal interface IAbility
    {
        #region Public Properties

        Ability Ability { get; }

        bool CanBeCasted { get; }

        bool Casted { get; }

        double CastPoint { get; }

        uint ManaCost { get; }

        #endregion
    }
}