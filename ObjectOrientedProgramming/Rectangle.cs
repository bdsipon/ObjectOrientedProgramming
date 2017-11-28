using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Rectangle
    {
        public int _width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new OverflowException();
                }
                _width = value;
            }
        }

        public int _height
        {
            get
            {
                return _height;
            }
            set
            {

                if (value < 0 || value > 100)
                {
                    throw new OverflowException();
                }
                _height = value;
            }

        }
    }
}
