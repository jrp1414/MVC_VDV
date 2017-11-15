using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.HtmlHelpers
{
    public static class CustomTextbox
    {
        //@Html.CTextBox("Name","Ram","Name")
        public static MvcHtmlString CTextBox(this HtmlHelper helper,string labelText,string value,string textBoxName)
        {
            var outerDiv = new TagBuilder("div");
            outerDiv.AddCssClass("row");

            var innerDiv1 = new TagBuilder("div");
            innerDiv1.AddCssClass("col-md-2");

            var label1 = new TagBuilder("label");
            label1.SetInnerText(labelText);

            //<label></label>
            //<input />
            innerDiv1.InnerHtml = label1.ToString(TagRenderMode.Normal);

            var innerDiv2 = new TagBuilder("div");
            innerDiv2.AddCssClass("col-md-2");

            var textBox = new TagBuilder("input");
            textBox.AddCssClass("form-control");
            textBox.Attributes.Add("id", textBoxName);
            textBox.Attributes.Add("name", textBoxName);
            textBox.Attributes.Add("value", value);

            innerDiv2.InnerHtml = textBox.ToString(TagRenderMode.SelfClosing);

            outerDiv.InnerHtml = innerDiv1.ToString(TagRenderMode.Normal) + innerDiv2.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(outerDiv.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString CTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression,helper.ViewData);
            return CTextBox(helper,metadata.DisplayName??metadata.PropertyName, metadata.Model!=null ? metadata.Model.ToString():string.Empty, metadata.PropertyName);
        }
    }
}