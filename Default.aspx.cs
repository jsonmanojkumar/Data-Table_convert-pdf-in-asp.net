using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.Adapters;
using System.Collections;
using System.Text.RegularExpressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;
using iTextSharp.text.html.simpleparser;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          
        }
    }
  
    //const string msgFormat = "table[{0}], tr[{1}], td[{2}], a: {3}, b: {4}";    
    //const string table_pattern = "<table.*?>(.*?)</table>";
    //const string tr_pattern = "<tr.*?>(.*?)</tr>";
    //const string td_pattern = "<td.*?>(.*?)</td>";
    //const string a_pattern = "<a href=\"(.*?)\"></a>";
    //const string b_pattern = "<b>(.*?)</b>";

    //private static List<string> GetContents(string input, string pattern)
    //{
    //    MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.Singleline);
    //    List<string> contents = new List<string>();
    //    foreach (Match match in matches)
    //    contents.Add(match.Value);
    //    return contents;
    //}

    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{        
    //    WebClient wc = new WebClient();
    //    string url = Request.Url.AbsoluteUri;
    //    string fileContent = wc.DownloadString(url);

    //    List<string> tableContents = GetContents(fileContent, table_pattern);
        
    //    string HTMLString = String.Join(" ", tableContents.ToArray());
       
    //    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
    //    PdfWriter.GetInstance(pdfDoc, Response.OutputStream);              
    //    pdfDoc.Open();
    //    pdfDoc.Add(new Paragraph("Welcome to dotnetfox"));
    //    List<IElement> htmlarraylist = HTMLWorker.ParseToList(new StringReader(HTMLString), null);
    //    for (int k = 0; k < htmlarraylist.Count; k++)
    //    {
    //        pdfDoc.Add((IElement)htmlarraylist[k]);
    //    }

    //    pdfDoc.Close(); 
    //    Response.ContentType = "application/pdf";
    //    Response.AddHeader("content-disposition", "attachment;" +
    //                                   "filename=sample.pdf");
    //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
    //    Response.Write(pdfDoc);
    //    Response.End();        
    //}    
}
