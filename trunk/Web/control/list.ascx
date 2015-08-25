<%@ Control Language="C#" AutoEventWireup="true" CodeFile="list.ascx.cs" Inherits="control_list" %>

<asp:Repeater ID="repList" runat="server">
<HeaderTemplate>
<ul>
</HeaderTemplate>
<ItemTemplate>
<li><a href="">游记</a></li>
</ItemTemplate>
<FooterTemplate>
</ul>
</FooterTemplate>
</asp:Repeater>

