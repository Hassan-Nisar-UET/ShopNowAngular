using Abp.Domain.Entities.Auditing;
using ShopNowAngular.Authorization.Users;
using ShopNowAngular.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.StoreRequests
{
    [Table("StoreRequests", Schema = "Store")]
    public class StoreRequest : FullAuditedEntity<Guid>
    {
        public string StoreName { get; set; }
        public long StoreOwnerId { get; set; } 
        public User StoreOwner {  get; set; }
        public StoreRequestStatus StorerequestStatus { get; set; }
    }
}
