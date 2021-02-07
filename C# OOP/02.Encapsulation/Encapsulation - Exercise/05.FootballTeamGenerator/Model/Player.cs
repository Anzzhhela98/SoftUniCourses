﻿using System;

namespace _05.FootballTeamGenerator.Model
{
    public class Player
    {
        private string name;

        public string Name
        {
            get => this.name;
            set
            {
                if (String.IsNullOrEmpty(value)||String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (String.Format(Common.Validator.INVALID_NAME, nameof(this.name)));
                }
                this.name = value;
            }
        }
        public Stats Stats { get; set; }
        
    }
}
