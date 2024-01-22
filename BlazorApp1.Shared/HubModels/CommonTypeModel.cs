using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.HubModels
{
    public  class CommonTypeModel
    {
        public CommonTypeModel()
        {

        }
        public string TypeName { get; set; }
        public int? ItemId { get; set; }
        public string? ItemText { get; set; } = string.Empty;
        public int? ItemOrder { get; set; } = 0;
        public int? ParentTypeId { get; set; }
        public string? ParentTypeName { get; set; }
    }
}
