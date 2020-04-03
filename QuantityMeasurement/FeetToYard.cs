﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// class declaration
    /// </summary>
    public class FeetToYard
    {
        public double feet;
        public double yard;
        public double inch;
        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="yard"></param>
        public FeetToYard(Feet feet, Yard yard)
        {
            this.feet = feet.feet;
            this.yard = yard.yard;

        }
        /// <summary>
        /// constructor overloading
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="yard"></param>
        public FeetToYard(Inches inch, Yard yard)
        {
            this.inch = inch.inches;
            this.yard = yard.yard;
        }
        /// <summary>
        /// method implementation
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="yard"></param>
        /// <returns>bool type</returns>
        public bool ComparedFeetAndYardValue(Feet feet, Yard yard)
        {
            if (this.feet == 0 && (this.feet.Equals(this.yard)))
                return true;
            if (this.feet == 1 && (this.feet.Equals(this.yard)))
                return false;
            if (this.feet == 1 && (this.yard.Equals(3 * this.feet)))
                return true;
            return false;
        }
        /// <summary>
        /// method implementation
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="yard"></param>
        /// <returns>bool type</returns>
        public bool ComparedInchesAndYardValue(Inches inch, Yard yard)
        {
            if (this.feet == 1 && (this.feet.Equals(this.yard)))
                return false;
            if (this.inch == 1 && (this.yard.Equals(36 * this.inch)))
                return true;
            return false;
        }
    }
}
