﻿using SFML.System;
using SS14.Shared.Maths;

namespace SS14.Shared.GO.Server
{
    public delegate void EntityMoveEvent(Vector2f toPosition, Vector2f fromPosition);
}