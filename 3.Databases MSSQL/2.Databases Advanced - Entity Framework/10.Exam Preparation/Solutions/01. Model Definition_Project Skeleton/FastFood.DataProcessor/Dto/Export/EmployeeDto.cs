namespace FastFood.DataProcessor.Dto.Export
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public OrdersDto[] Orders { get; set; }
    }
}
