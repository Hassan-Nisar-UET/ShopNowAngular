using Abp.Domain.Entities.Auditing;
using ShopNowAngular.Categories;
using ShopNowAngular.SubSubCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.SubCategories
{
    [Table("SubSubCategories", Schema = "SubCategory")]
    public class SubCategory : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<SubSubCategory> SubSubCategories { get; set; }

        public SubCategory()
        {
            SubSubCategories = new List<SubSubCategory>();
        }
    }
}
