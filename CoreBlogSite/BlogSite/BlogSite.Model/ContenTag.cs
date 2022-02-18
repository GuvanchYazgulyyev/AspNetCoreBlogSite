


namespace BlogSite.Model
{
    using System;
    public  class ContenTag : Core.ModelBase
    {
        public ContenTag(int contentid, int tagid)
        {
            Contentid = contentid;
            Tagid = tagid;
        }
        public int Contentid { get; set; }
        public int Tagid { get; set; }
    }
}
