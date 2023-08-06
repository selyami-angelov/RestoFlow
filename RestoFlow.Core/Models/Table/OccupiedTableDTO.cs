using RestoFlow.Core.Models.Order;
using RestoFlow.Core.Models.User;

namespace RestoFlow.Core.Models.Table
{
    public class OccupiedTableDTO
    {
        public TableDTO Table { get; set; }

        public UserDTO User { get; set; } 

        public List<OrderDTO> Orders { get; set; }
    }
}
