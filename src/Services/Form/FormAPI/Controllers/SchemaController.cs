using Form.API.Model;
using Form.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SchemaController : ControllerBase
	{
		private ISchemaRepository schemaRepo;

		public SchemaController(ISchemaRepository schema)
		{
			schemaRepo = schema;
		}

		[HttpPost]
		[Route("all")]
		public FormSchemaViewModel GetSchemaOfForm(SchemaRequestModel model)
		{
			return schemaRepo.GetSchemaOfForm(model);
		}
	}
}
