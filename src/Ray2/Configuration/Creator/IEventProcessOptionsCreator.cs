﻿using System;
using System.Collections.Generic;

namespace Ray2.Configuration.Creator
{
    public interface IEventProcessOptionsCreator
    {
        EventProcessOptions Create(Type type);
    }
}
