﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XCRI.XmlBaseClasses;

namespace XCRI
{
    public class Identifier : ElementWithSingleValue<string>, Interfaces.IIdentifier
	{

		#region Constructors

		#region Public

		public Identifier()
            : base("identifier", Configuration.XCRICAP11NamespaceUri)
		{

		}

		#endregion

		#endregion

	}
}
