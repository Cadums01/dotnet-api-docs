<%@ Register TagPrefix="aspSample" Namespace="Samples.AspNet.CS.Controls" Assembly="Samples.AspNet.CS" %>
<%@ Page Language="C#" AutoEventWireup="True" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
    <head>
        <title>Custom TextBox - TagKey - C# Example</title>
    </head>
    <body>
        <form id="Form1" method="post" runat="server">
            <h3>Custom TextBox - TagKey - C# Example</h3>
            
            <aspSample:CustomTextBoxTagKey 
              id="TextBox1" 
              runat="server">Hello World!
            </aspSample:CustomTextBoxTagKey>
            
        </form>
    </body>
</html>