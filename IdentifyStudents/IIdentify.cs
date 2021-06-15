using System;
using System.Collections.Generic;
using System.Text;

namespace IdentifyStudents
{
    interface IIdentify
    {
        double DecodePhoto(double photoCode);

        long IdentifyStudents();
    }
}
