using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public static Car carToDelete;

        public int Id { get; set; }
        public int BrantId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public string DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
