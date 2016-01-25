using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTagBuilder.Tags
{
    public class Span : BaseTag
    {
        public Span(BaseTag parent) : base("span", parent)
        {
        }

        public Span Id(string id)
        {
            _id = newHtmlAttribute("id", id);
            return this;
        }
    }
}
