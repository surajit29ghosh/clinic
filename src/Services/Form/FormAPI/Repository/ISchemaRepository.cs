using Form.API.Model;

namespace Form.API.Repository
{
	public interface ISchemaRepository
	{
		FormSchemaViewModel GetSchemaOfForm(SchemaRequestModel model);
	}
}