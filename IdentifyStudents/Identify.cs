using System;
using System.Collections.Generic;
using System.Text;

namespace IdentifyStudents
{
    class Identify : IIdentify
    {
        /// <summary>
        /// Get Photo code and decoded it
        /// </summary>
        /// <param name="photoCode"></param>
        /// <returns>Photo that can be processed by func</returns>
        public double DecodePhoto(double photoCode) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Work with decoded students
        /// </summary>
        /// <returns>Count of Students</returns>
        public long IdentifyStudents()
        {
            throw new NotImplementedException();
        }
    }
}
