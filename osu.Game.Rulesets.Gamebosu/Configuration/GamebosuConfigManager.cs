﻿// gamebosu! ruleset. Copyright Lucas A. aka Game4all. Licensed under GPLv3.
// See LICENSE at root of repo for more information on licensing.

using osu.Game.Configuration;
using osu.Game.Rulesets.Configuration;

namespace osu.Game.Rulesets.Gamebosu.Configuration
{
    public class GamebosuConfigManager : RulesetConfigManager<GamebosuSetting>
    {
        public GamebosuConfigManager(SettingsStore settings, RulesetInfo ruleset)
            : base(settings, ruleset, 0)
        {
        }

        protected override void InitialiseDefaults()
        {
            Set(GamebosuSetting.LockClockRate, false);
            Set(GamebosuSetting.ClockRate, 1, 0.1, 5, 0.1);
            Set(GamebosuSetting.PreferGBCMode, true);
            Set(GamebosuSetting.GameboyScale, 2f, 1f, 4.5f, 0.1f);
            Set(GamebosuSetting.EnableSoundPlayback, false); //Disable the audio playback by default since it is very experimental.
            base.InitialiseDefaults();
        }
    }

    public enum GamebosuSetting
    {
        LockClockRate,
        ClockRate,
        GameboyScale,
        PreferGBCMode,
        EnableSoundPlayback,
    }
}