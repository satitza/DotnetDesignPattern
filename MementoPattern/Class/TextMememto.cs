﻿using MememtoPattern.Interface;

namespace MememtoPattern.Class
{
    public class TextMemento
    {
        public string State { get; }

        public TextMemento(string state)
        {
            State = state;
        }
    }
}
