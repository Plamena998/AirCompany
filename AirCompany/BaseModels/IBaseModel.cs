using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.BaseModels
{
    public interface IBaseModel
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
      
        public DateTimeOffset? UpdatedAt { get; set;}
        public DateTimeOffset? DeletedAt { get; set; }

    }
}
