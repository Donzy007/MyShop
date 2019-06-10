using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public abstract class BassEntity
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public BassEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
        }
    }
}
