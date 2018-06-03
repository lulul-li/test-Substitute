namespace UnitTestProject1
{
    public class ModelController
    {
        public IModel _model;

        public void RemoveAdultAge()
        {
            _model.Delete(o => o.Customer.Age > 18);
        }
    }
}