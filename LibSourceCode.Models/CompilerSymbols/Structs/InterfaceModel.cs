﻿using System;

namespace Bau.Libraries.LibSourceCode.Models.CompilerSymbols.Structs
{	
	/// <summary>
	///		Modelo con los datos de un interface
	/// </summary>
	public class InterfaceModel : BaseComplexModel
	{
		public InterfaceModel(Base.LanguageStructModel objParent) : base(StructType.Interface, objParent) {}
	}
}
