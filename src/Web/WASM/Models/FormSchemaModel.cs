using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
	public class FormSchemaModel
	{
		public FormInfoModel Form { get; set; }

		public IEnumerable<SchemaInfoModel> Schemas { get; set; }
	}
}
