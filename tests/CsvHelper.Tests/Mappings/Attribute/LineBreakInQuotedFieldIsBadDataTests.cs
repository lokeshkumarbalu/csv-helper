﻿using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CsvHelper.Tests.Mappings.Attribute
{
	public class LineBreakInQuotedFieldIsBadDataTests
	{
		[Fact]
		public void ConstructorAttributeTest()
		{
			var config = new CsvConfiguration(CultureInfo.InvariantCulture, typeof(Foo));
			Assert.True(config.LineBreakInQuotedFieldIsBadData);
		}

		[LineBreakInQuotedFieldIsBadData(true)]
		private class Foo { }
	}
}