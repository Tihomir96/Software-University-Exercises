using FastFood.DataProcessor.Dto.Import;

namespace FastFood.DataProcessor.Dto.Export
{
    public class OrdersDto
    {
        public string Customer { get; set; }
        public ItemDtoExport[] Items { get; set; }

    }
}