﻿using CompositePattern.Abstract;

namespace CompositePattern.Class
{
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}