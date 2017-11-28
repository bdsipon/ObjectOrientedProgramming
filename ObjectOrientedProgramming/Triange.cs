using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Triange
    {
        private int _height;
        private int _baseLength;

        public Triange()
        {
            _height = _baseLength = 5;
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value<1 || value>100)
                {
                    throw new OverflowException();
                }
                _height = value;
            }
        }
        public int BaseLength
        {
            get
            {
                return _baseLength;
            }
            set
            {
                if(value<1 || value>100)
                {
                    throw new OverflowException();
                }
                _baseLength = value;
            }
        }
        public double Area
        {
            get
            {
                return _height * _baseLength * 0.5;
            }
        }
    }
}
