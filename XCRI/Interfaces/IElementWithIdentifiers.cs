﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCRI.Interfaces
{
    public interface IElementWithIdentifiers
    {
        IList<IIdentifier> Identifiers { get; }
    }
    public interface IIdentifier : IXmlElementWithSingleValue<string>
    {
    }
}