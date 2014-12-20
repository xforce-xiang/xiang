using System;
using System.Windows.Forms;
using System.Xml;

namespace xml_练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private XmlTextWriter tw;
        private void btnStart_Click(object sender, EventArgs e)
        {
            tw = new XmlTextWriter("student.xml",null);
            tw.Formatting = Formatting.Indented;//设置格式，对元素的内容进行缩进
            tw.WriteStartDocument();//书写xml声明
            tw.WriteStartElement("学生列表");


            //// 写出在名称和文本之间带有空格的处理指令
            //String pitext = "type='text/xsl' href='book.xsl'";
            //tw.WriteProcessingInstruction("xml-stylesheet", pitext);

            ////增加指定名称和可选属性的Doctype声明
            //tw.WriteDocType("学生", null, null, "<!ENTITY sex '男'>");
            ////注释
            //tw.WriteComment("XML注释");

            ////开始创建元素
            //tw.WriteStartElement("学生");
            ////创建属性
            //tw.WriteAttributeString("专业", "计算机");
            //tw.WriteAttributeString("日期", "2008-09-01");

            ////创建元素
            //tw.WriteElementString("姓名", "李天平");
            //tw.WriteStartElement("性别");
            //tw.WriteEntityRef("sex");
            //tw.WriteEndElement();
            //tw.WriteElementString("年龄", "25");

            ////写CData信息
            //tw.WriteCData("年龄大了");

            ////关闭跟
            //tw.WriteEndElement();
            //tw.WriteEndDocument();

            ////写XML文件，并关闭tw
            //tw.Flush();
            //tw.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tw.WriteStartElement("学生");  //生成学生元素的开始标记
            tw.WriteAttributeString("类别", cmbType.SelectedText);//生成类别属性
            tw.WriteAttributeString("学号", txtNo.Text);//生成学号
            tw.WriteStartElement("姓名");
            tw.WriteAttributeString("中文名", txtCnName.Text);
            tw.WriteAttributeString("英文名", txtEnName.Text);
            tw.WriteEndElement();
            string sex = "";
            if(rdoMale.Checked)
            {
                sex = rdoMale.Text;
            }
            else
            {
                sex = rdoFemale.Text;
                tw.WriteElementString("性别", sex);
                tw.WriteElementString("电话", txtTel.Text);
                tw.WriteEndElement();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Close();
        }
    }
}
