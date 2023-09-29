using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EStoreWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Vui long nhap ten the loai")]
        [StringLength(30,ErrorMessage ="Chieu dai toi da 30 ky tu")]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage = "Please input value [1 - 100]")]
        public int DisplayOrder { get; set; }
    }
}
