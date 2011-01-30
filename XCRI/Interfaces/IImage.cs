﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCRI.Interfaces
{
    public interface IImage : IXmlElement
    {
        Uri Source { get; set; }
        string Title { get; set; }
        string Alt { get; set; }
    }
}