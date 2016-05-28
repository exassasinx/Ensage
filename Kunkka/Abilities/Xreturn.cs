﻿namespace Kunkka.Abilities
{
    using Ensage;
    using Ensage.Common;
    using Ensage.Common.Extensions;

    internal class Xreturn : IAbility
    {
        #region Constructors and Destructors

        public Xreturn(Ability ability)
        {
            Ability = ability;
            CastPoint = ability.FindCastPoint();
        }

        #endregion

        #region Public Properties

        public Ability Ability { get; }

        public bool CanBeCasted => Utils.SleepCheck("Kunkka.Xreturn") && !Ability.IsHidden && Ability.CanBeCasted();

        public bool Casted => Ability.IsHidden;

        public double CastPoint { get; }

        public uint ManaCost { get; } = 0;

        #endregion

        #region Public Methods and Operators

        public void UseAbility()
        {
            Ability.UseAbility();
            Utils.Sleep(CastPoint * 1000 + 200, "Kunkka.Xreturn");
        }

        #endregion
    }
}