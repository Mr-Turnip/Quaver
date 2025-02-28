/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) Swan & The Quaver Team <support@quavergame.com>.
*/

using Microsoft.Xna.Framework;
using Quaver.API.Enums;
using Quaver.Shared.Helpers;

namespace Quaver.Shared.Modifiers.Mods
{
    public class ModNoFail : IGameplayModifier
    {
        public string Name { get; set; } = "No Fail";

        public ModIdentifier ModIdentifier { get; set; } = ModIdentifier.NoFail;

        public ModType Type { get; set; } = ModType.Special;

        public string Description { get; set; } = "Failure is not an option.";

        public bool Ranked() => false;

        public bool AllowedInMultiplayer { get; set; } = true;

        public bool OnlyMultiplayerHostCanCanChange { get; set; }

        public bool ChangesMapObjects { get; set; }

        public ModIdentifier[] IncompatibleMods { get; set; } =
        {
            ModIdentifier.Autoplay,
        };

        public Color ModColor { get; } = ColorHelper.HexToColor("#2F80ED");

        public void InitializeMod() {}
    }
}
