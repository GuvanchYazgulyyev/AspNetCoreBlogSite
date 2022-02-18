using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Model
{
  public  class Author : Core.ModelBase
    {
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }

        [NotMapped]
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
  
    }
}
