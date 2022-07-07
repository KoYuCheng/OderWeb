<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label">請輸入訂位資訊</asp:Label>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="姓名:"></asp:Label>
    
        <asp:TextBox ID="textname" runat="server" OnTextChanged="textname_TextChanged" ></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label">電話:</asp:Label>
    
        <asp:TextBox ID="texttel" runat="server" OnTextChanged="texttel_TextChanged" MaxLength="10" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label">訂位日期:</asp:Label>
    
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="245px" Width="280px" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label">用餐人數:</asp:Label>
    
        <asp:TextBox ID="textpeople" runat="server"  OnTextChanged="textpeople_TextChanged" onkeypress="return IsIntText();" TextMode="Number"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label">餐廳:</asp:Label>
    
        <asp:DropDownList ID="dwnres" runat="server" OnSelectedIndexChanged="dwnres_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="=請選擇餐廳=">=請選擇餐廳=</asp:ListItem>
            <asp:ListItem Value="美美早午餐">美美早午餐</asp:ListItem>
            <asp:ListItem Value="大美樂比薩屋">大美樂比薩屋</asp:ListItem>
            <asp:ListItem Value="鮮魚海鮮">鮮魚海鮮</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label">用餐時段:</asp:Label>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1">
            <asp:ListItem Value="0"></asp:ListItem>
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Visible="False" TabIndex="2">
            <asp:CheckBox ID="cbxhumbger" runat="server" Text="漢堡" />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
            </asp:DropDownList>
            份<br /> 
            <asp:CheckBox ID="cbxsandwish" runat="server" Text="三明治" />
            <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
            </asp:DropDownList>
            份<br /> 
            <asp:CheckBox ID="cbxpank" runat="server" Text="鬆餅" />
            <asp:DropDownList ID="DropDownList6" runat="server" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
            份<br /> 
            <asp:CheckBox ID="cbxsoup" runat="server" Text="玉米濃湯" />
            <asp:DropDownList ID="DropDownList7" runat="server" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
            </asp:DropDownList>
            份</asp:Panel>
        <br />
        <br />
    
    </div>
        <asp:Button ID="btn01" runat="server" Text="送出" OnClick="btn01_Click" />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Visible="False">
            <asp:Label ID="textname1"  runat="server" ForeColor="Blue"></asp:Label>
        <br />
        
        <asp:Label ID="texttel1"  runat="server" ForeColor="Blue"></asp:Label>
        <br />
        
        <asp:Label ID="txtDate"  runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <asp:Label ID="textpeople1"  runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <asp:Label ID="txtres" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <asp:Label ID="txttime1" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <asp:Label ID="txtMsg" runat="server" ForeColor="Blue"></asp:Label>
        </asp:Panel>
        <br />
        
        
    </form>
</body>
</html>
