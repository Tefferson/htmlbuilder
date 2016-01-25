using System;
using System.Collections.Generic;
using System.Linq;

namespace HTMLTagBuilder.Tags
{
    public class BaseTag
    {
        private string TagName { get; set; }
        public IList<string> Classes { get; set; }
        public string _id { get; set; }
        protected BaseTag Parent { get; private set; }

        private IList<BaseTag> content;

        public string paragraphOffset;
        protected string newHtmlAttribute(string name, string value)
        {
            return string.Format("{0}='{1}'", name, value);
        }
        public BaseTag(string tagName, BaseTag parent) : base()
        {
            content = new List<BaseTag>();
            Parent = parent;
            TagName = tagName;
            this.paragraphOffset = parent == null ? "" : (parent.paragraphOffset + " ");
        }
        public BaseTag(BaseTag parent) : this("html", parent)
        {
        }
        public override string ToString()
        {
            string attributes = "";
            string childrenContent = "";
            string baseLine = Environment.NewLine + paragraphOffset + "{0}" + Environment.NewLine + paragraphOffset;

            typeof(BaseTag).GetProperties()
                         .Select(prop => prop.GetValue(this, null))
                         .Where(val => val != null)
                         .Select(val => val.ToString())
                         .Where(str => str.Length > 0)
                         .ToList()
                         .ForEach(a => attributes += " " + a);

            content.ToList().ForEach(c => childrenContent += string.Format(baseLine, c));

            return string.Format("<{0}{1}>{2}</{0}>", TagName, attributes, childrenContent);
        }

        public BaseTag Close()
        {
            return Parent;
        }
        public Div Div()
        {
            Tags.Div div = new Tags.Div(this);
            content.Add(div);
            return div;
        }
    }
}
