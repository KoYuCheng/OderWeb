using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void dwnres_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        switch (dwnres.SelectedValue)
        {
            case "=請選擇餐廳=":
                RadioButtonList1.Visible = false;
                Panel1.Visible = false;
                textname1.Visible = false;
                texttel1.Visible = false;
                txtDate.Visible = false;
                textpeople1.Visible = false;
                txtres.Visible = false;
                txttime1.Visible = false;
                txtMsg.Visible = false;
                break;

            case "美美早午餐":
                RadioButtonList1.Visible = true;
                RadioButtonList1.Items[0].Text = "7:00";
                RadioButtonList1.Items[1].Text = "8:00";
                RadioButtonList1.Items[2].Text = "9:00";
                RadioButtonList1.Items[3].Text = "10:00";
                RadioButtonList1.Items[4].Text = "11:00";
                RadioButtonList1.Items[5].Text = "12:00";

                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                RadioButtonList1.Items[4].Selected = false;
                RadioButtonList1.Items[5].Selected = false;
                Panel1.Visible = true;
                cbxhumbger.Checked = false;
                cbxsandwish.Checked = false;
                cbxpank.Checked = false;
                cbxsoup.Checked = false;

                cbxhumbger.Text = "漢堡";
                cbxsandwish.Text = "三明治";
                cbxpank.Text = "鬆餅";
                cbxsoup.Text = "玉米濃湯";

                for (int i = 1; i < 5; i++) {
                    DropDownList1.Items[i].Selected = false;
                    DropDownList5.Items[i].Selected = false;
                    DropDownList6.Items[i].Selected = false;
                    DropDownList7.Items[i].Selected = false;
                }
                DropDownList1.Items[0].Selected = true;
                DropDownList5.Items[0].Selected = true;
                DropDownList6.Items[0].Selected = true;
                DropDownList7.Items[0].Selected = true;
                    

               
                break;

            case "大美樂比薩屋":

                RadioButtonList1.Visible = true;
                RadioButtonList1.Items[0].Text = "11:00";
                RadioButtonList1.Items[1].Text = "12:00";
                RadioButtonList1.Items[2].Text = "13:00";
                RadioButtonList1.Items[3].Text = "17:00";
                RadioButtonList1.Items[4].Text = "18:00";
                RadioButtonList1.Items[5].Text = "19:00";

                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                RadioButtonList1.Items[4].Selected = false;
                RadioButtonList1.Items[5].Selected = false;
                Panel1.Visible = true;
                cbxhumbger.Checked = false;
                cbxsandwish.Checked = false;
                cbxpank.Checked = false;
                cbxsoup.Checked = false;

                cbxhumbger.Text = "夏威夷披薩";
                cbxsandwish.Text = "海鮮披薩";
                cbxpank.Text = "炸雞";
                cbxsoup.Text = "可樂";
                for (int i = 1; i < 5; i++)
                {
                    DropDownList1.Items[i].Selected = false;
                    DropDownList5.Items[i].Selected = false;
                    DropDownList6.Items[i].Selected = false;
                    DropDownList7.Items[i].Selected = false;
                }

                DropDownList1.Items[0].Selected = true;
                DropDownList5.Items[0].Selected = true;
                DropDownList6.Items[0].Selected = true;
                DropDownList7.Items[0].Selected = true;
                
                break;
            case "鮮魚海鮮":

                RadioButtonList1.Visible = true;
                RadioButtonList1.Items[0].Text = "17:00";
                RadioButtonList1.Items[1].Text = "18:00";
                RadioButtonList1.Items[2].Text = "19:00";
                RadioButtonList1.Items[3].Text = "20:00";
                RadioButtonList1.Items[4].Text = "21:00";
                RadioButtonList1.Items[5].Text = "22:00";

                RadioButtonList1.Items[0].Selected = false;
                RadioButtonList1.Items[1].Selected = false;
                RadioButtonList1.Items[2].Selected = false;
                RadioButtonList1.Items[3].Selected = false;
                RadioButtonList1.Items[4].Selected = false;
                RadioButtonList1.Items[5].Selected = false;
                Panel1.Visible = true;
                cbxhumbger.Checked = false;
                cbxsandwish.Checked = false;
                cbxpank.Checked = false;
                cbxsoup.Checked = false;

                cbxhumbger.Text = "焗烤龍蝦";
                cbxsandwish.Text = "烤鯖魚";
                cbxpank.Text = "炒三鮮";
                cbxsoup.Text = "蛤蜊湯";

                for (int i = 1; i < 5; i++)
                {
                    DropDownList1.Items[i].Selected = false;
                    DropDownList5.Items[i].Selected = false;
                    DropDownList6.Items[i].Selected = false;
                    DropDownList7.Items[i].Selected = false;
                }
                DropDownList1.Items[0].Selected = true;
                DropDownList5.Items[0].Selected = true;
                DropDownList6.Items[0].Selected = true;
                DropDownList7.Items[0].Selected = true;
                break;

        }
    }
    protected void textname_TextChanged(object sender, EventArgs e)
    {

    }
    protected void texttel_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void textpeople_TextChanged(object sender, EventArgs e)
    {

    }



    protected void btn01_Click(object sender, EventArgs e)
    {
        String tel = texttel.Text.ToString();
        String date = Calendar1.SelectedDate.ToLongDateString();
        int people = 0;
        

        if (textname.Text == "" || texttel.Text == "" || textpeople.Text == "")
        {
            Response.Write("<script>alert('不可為空白 請填寫資料')</script>");
        }
        else if (tel[0] != '0') { Response.Write("<script>alert('電話開頭必須是0')</script>"); }
        else if (tel.Length != 10) { Response.Write("<script>alert('電話需是10碼')</script>"); }
        else if (date == "0001年1月1日") { Response.Write("<script>alert('請選擇訂餐日期')</script>"); }
        else if (dwnres.SelectedIndex == 0) { 
            Response.Write("<script>alert('請選擇 用餐資訊')</script>");
            Panel2.Visible = false;
        }
        else if (RadioButtonList1.SelectedIndex == -1) { Response.Write("<script>alert('請選擇用餐時段')</script>"); }
        else
        {
            people = Int32.Parse(textpeople.Text.ToString());
            if (people <= 0) { Response.Write("<script>alert('人數須為正整數')</script>"); }


            Panel2.Visible = true;

                if (cbxhumbger.Checked == false && cbxsandwish.Checked == false && cbxpank.Checked == false
                        && cbxsoup.Checked == false) { Response.Write("<script>alert('請勾選餐點')</script>"); }
                else
                {
                    txtMsg.Text = "";
                    if (cbxhumbger.Checked)
                    {
                        txtMsg.Text += "你的選擇為：<br/>" + cbxhumbger.Text + DropDownList1.SelectedValue.ToString() + "份<br/>";
                    }
                    if (cbxsandwish.Checked)
                    {
                        txtMsg.Text += cbxsandwish.Text + DropDownList5.SelectedValue.ToString() + "份<br/>";

                    }
                    if (cbxpank.Checked)
                    {
                        txtMsg.Text += cbxpank.Text + DropDownList6.SelectedValue.ToString() + "份<br/>";

                    }
                    if (cbxsoup.Checked)
                    {
                        txtMsg.Text += cbxsoup.Text + DropDownList7.SelectedValue.ToString() + "份<br/>";

                    }

                    textname1.Text = "您的姓名:" + textname.Text.ToString();
                    texttel1.Text = "您的電話:" + texttel.Text.ToString();
                    txtDate.Text = "您的訂位日期:" + Calendar1.SelectedDate.ToLongDateString();
                    textpeople1.Text = "您的訂位人數:" + people + "人";
                    txtres.Text = "用餐餐廳:" + dwnres.SelectedValue.ToString();
                    txttime1.Text = "您選擇的用餐時段為:" + RadioButtonList1.SelectedItem.ToString();
                }

            
        }
    }


    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.Date <= DateTime.Now.Date)
        {
            e.Day.IsSelectable = false;
        }
        else {
            e.Day.IsSelectable = true;
        }

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList1.SelectedItem.Selected=true;
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList5.SelectedItem.Selected = true;
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList6.SelectedItem.Selected = true;
    }
    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList7.SelectedItem.Selected = true;
    }
    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}