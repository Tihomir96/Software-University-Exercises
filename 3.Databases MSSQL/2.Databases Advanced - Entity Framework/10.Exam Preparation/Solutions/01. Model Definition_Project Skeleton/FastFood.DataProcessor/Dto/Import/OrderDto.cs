using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Import
{
    [XmlType("Order")]
    public class OrderDto
    {
        public string Customer { get; set; }        
        public string Employee { get; set; }

        public string DateTime { get; set; }
        public string Type { get; set; } = "ForHere";
        public OrderItemDto[] Items { get; set; }
    }
}
