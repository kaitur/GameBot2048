using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBot2048
{
    class MyClass
    {
        public static int Rows
        {
            get { return rows; }
            set { rows = value; if (SomeEvent != null) SomeEvent(null, EventArgs.Empty); }
        }
        public static int Columns
        {
            get { return columns; }
            set { columns = value; if (SomeEvent != null) SomeEvent(null, EventArgs.Empty); }
        }
        public static int Speed
        {
            get { return speed; }
            set { speed = value; if (SomeEvent != null) SomeEvent(null, EventArgs.Empty); }
        }

        static int rows;
        static int columns;
        static int speed;

        public static event EventHandler SomeEvent;

    }
}
