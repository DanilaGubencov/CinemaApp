using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Row
    {
        public string RowNumber { get; set; }
        public List<Seat> Seats { get; set; } // Обязательно добавьте это свойство
    }
}
