namespace HTMLTagBuilder.Tags
{
    public class Div : BaseTag
    {
        public Div(BaseTag parent) : base("div", parent)
        {
        }
        
        public Div Id(string id)
        {
            _id = newHtmlAttribute("id", id);
            return this;
        }
    }
}
