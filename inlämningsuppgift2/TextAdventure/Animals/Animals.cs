﻿using System;
namespace TextAdventure.Animals
{
    public class Animals
    {

        private string name;

        private string info;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                this.info = value;
            }
        }

        public Animals(string name, string info)
        {
            this.name = name;
            this.info = info; 
        }

        public Animals()
        {
            
        }
    }
}
