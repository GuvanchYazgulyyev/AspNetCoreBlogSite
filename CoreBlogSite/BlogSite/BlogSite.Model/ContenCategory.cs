


namespace BlogSite.Model
{
    using System;
    public  class ContenCategory : Core.ModelBase
    {
        public ContenCategory(int contentid, int categoryid)
        {
            Contentid = contentid;
            Categoryid = categoryid;
        }
        public int Contentid { get; set; }
        public int Categoryid { get; set; }
    }
}
