using System;


namespace BlogSite.Model
{
  public  class Comment: Core.ModelBase
    {
        public int Contentid { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Text { get; set; }
        public bool IsApprovied { get; set; }
  
    }
}
