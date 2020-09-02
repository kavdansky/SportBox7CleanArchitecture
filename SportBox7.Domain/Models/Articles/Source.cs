using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Models.Articles
{
    public class Source
    {
        private string sourceUrl;

        private string sourceName;

        public Source(string sourceUrl, string sourceName)
        {
            this.SourceName = sourceName;
            this.SourceURL = sourceUrl;
        }

        public string SourceURL { get; set; }

        public string SourceName { get; set; }
    }


}
