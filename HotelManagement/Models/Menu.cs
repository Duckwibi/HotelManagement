﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public int IsActive { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int Levels { get; set; }
        public int ParentId { get; set; }
        public string Link { get; set; }
        public int MenuOrder {  get; set; }
        public int Position { get; set; }
        public string IconClassName { get; set; }

    }
}
