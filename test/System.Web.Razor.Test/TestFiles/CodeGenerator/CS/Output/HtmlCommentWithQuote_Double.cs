//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:N.N.NNNNN.N
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestOutput {
using System;

public class HtmlCommentWithQuote_Double {
#line hidden
public HtmlCommentWithQuote_Double() {
}
public override void Execute() {
WriteLiteral("<!-- \" -->\r\n<img");

WriteAttribute("src", Tuple.Create(" src=\"", 16), Tuple.Create("\"", 41)
, Tuple.Create(Tuple.Create("", 22), Tuple.Create<System.Object, System.Int32>(Href("~/images/submit.png")
, 22), false)
);

WriteLiteral(" />");

}
}
}
