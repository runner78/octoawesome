﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OctoAwesome
{
    public interface IUniverse
    {
        int Id { get; }

        string Name { get; }

        IPlanet GetPlanet(int id);

        void SetPlanet(IPlanet planet);
    }
}
