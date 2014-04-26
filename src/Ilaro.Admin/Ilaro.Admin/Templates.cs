﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ilaro.Admin
{
	/// <summary>
	/// Container for magic strings with names of partial views
	/// </summary>
	public class Templates
	{
		/// <summary>
		/// Editor partials views
		/// </summary>
		public class Editor
		{
			public const string Text = "TextBoxPartial";

			public const string Date = "DatePartial";

			public const string DateTime = "DateTimePartial";

			public const string Time = "TimePartial";

			public const string File = "FilePartial";

			public const string Numeric = "NumericPartial";

			public const string Password = "PasswordPartial";

			public const string Html = "HtmlPartial";

			public const string TextArea = "TextAreaPartial";

			public const string TextBox = "TextBoxPartial";

			public const string DropDownList = "DropDownListPartial";

			public const string CheckBox = "CheckBoxPartial";
		}

		/// <summary>
		/// Display partials views
		/// </summary>
		public class Display
		{
			public const string Text = "TextPartial";

			public const string Date = "DatePartial";

			public const string DateTime = "DateTimePartial";

			public const string Time = "TimePartial";

			public const string Link = "LinkPartial";

			public const string Image = "ImagePartial";

			public const string Numeric = "NumericPartial";

			public const string Hash = "HashPartial";

			public const string Html = "HtmlPartial";

			public const string Bool = "BoolPartial";
		}
	}
}