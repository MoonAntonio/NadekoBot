﻿using System;

namespace NadekoBot.Services.Database.Models
{
    public class RewardedUser
    {
        public ulong UserId { get; set; }
        public int AmountRewardedThisMonth { get; set; }
        public DateTime LastReward { get; set; }
    }
}