namespace HtmlGenerator
{
    public class HtmlArticleElement : HtmlElement 
    {
        public HtmlArticleElement() : base("article", false) 
        {    
        }

		public HtmlArticleElement WithAccessKey(string value) => (HtmlArticleElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlArticleElement WithClass(string value) => (HtmlArticleElement)WithAttribute(Attribute.Class(value));

		public HtmlArticleElement WithContentEditable(string value) => (HtmlArticleElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlArticleElement WithContextMenu(string value) => (HtmlArticleElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlArticleElement WithDir(string value) => (HtmlArticleElement)WithAttribute(Attribute.Dir(value));

		public HtmlArticleElement WithHidden(string value) => (HtmlArticleElement)WithAttribute(Attribute.Hidden(value));

		public HtmlArticleElement WithId(string value) => (HtmlArticleElement)WithAttribute(Attribute.Id(value));

		public HtmlArticleElement WithLang(string value) => (HtmlArticleElement)WithAttribute(Attribute.Lang(value));

		public HtmlArticleElement WithSpellCheck(string value) => (HtmlArticleElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlArticleElement WithStyle(string value) => (HtmlArticleElement)WithAttribute(Attribute.Style(value));

		public HtmlArticleElement WithTabIndex(string value) => (HtmlArticleElement)WithAttribute(Attribute.TabIndex(value));
    }
}