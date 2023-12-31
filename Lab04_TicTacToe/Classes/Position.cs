﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Position
    {
        /// <summary>
        /// Row number value
        /// </summary>
        public int Row { get; set; }
        /// <summary>
        /// Column number value
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Position on the gameboard being initialized 
        /// </summary>
        /// <param name="row">row number</param>
        /// <param name="column">column number</param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}