using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiusEcom.Products
{
    public class Product : Volo.Abp.Domain.Entities.Auditing.CreationAuditedAggregateRoot<Guid>
    {
        public Guid ManufactureId { get; set; }
        public string Code { get; set; }
        public string SKU { get; set; }
        public string SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
    }
}
