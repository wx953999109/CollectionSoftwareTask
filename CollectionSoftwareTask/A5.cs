using Ivony.Html;
using Ivony.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionSoftwareTask
{
    public partial class A5 : UserControl
    {
        public A5()
        {
            InitializeComponent();
            Readload();
        }

        string A5Host = "https://www.a5.cn/";

        void Readload()
        {
            listTasks.Items.Clear();

            tbLog.Text = "读取页数";
            IHtmlDocument source = new JumonyParser().LoadDocument("https://www.a5.cn/tasklist-o-1-page-1.html", System.Text.Encoding.GetEncoding("utf-8"));

            var tmpLis = source.Find(".m-page-nums .pagination li");
            int pageCount = Convert.ToInt32(tmpLis.ElementAt(tmpLis.Count() - 2).InnerText());
            for (int pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                tbLog.Text = $"加载第{pageIndex}页数据";
                LoadTaskList($"https://www.a5.cn/tasklist-o-1-page-{pageIndex}.html");
            }
            tbLog.Text = "加载完毕, 开始预加载";
            PreLoad();
        }

        void PreLoad()
        {
            var items = listTasks.Items;
            new Task(() =>
            {
                for (int i = 0; i < items.Count; i++)
                {
                    string url = "";
                    this.Invoke(new Action(() =>
                    {
                        tbLog.Text = $"开始预加载第{i + 1}个/{items.Count}个, " + url;
                        url = items[i].Tag.ToString();
                    }));
                    LoadDetail(url);
                }
                this.Invoke(new Action(() => { tbLog.Text = "预加载完毕"; }));

            }).Start();

        }

        void LoadTaskList(string url)
        {
            IHtmlDocument source = new JumonyParser().LoadDocument(url, System.Text.Encoding.GetEncoding("utf-8"));


            var links = source.Find(".m-tk-list").ElementAt(0).Find("h3 a");
            if (links == null || links.Count() == 0) return;
            for (int i = 0; i < links.Count(); i++)
            {
                var link = links.ElementAt(i);
                string path = link.Attribute("href").Value();
                string detailTaskUrl = A5Host + path;
                ListViewItem lvi = new ListViewItem($"【{i + 1 + listTasks.Items.Count}】 {link.InnerText()}")
                {
                    Tag = detailTaskUrl
                };
                listTasks.Items.Add(lvi);
            }
        }

        Dictionary<string, MyHtml> cacheHtml = new Dictionary<string, MyHtml>();
        private void listTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTasks.SelectedItems.Count < 1) return;
            string url = listTasks.SelectedItems[0].Tag.ToString();
            MyHtml myHtml = LoadDetail(url);

            //标题
            tbTitle.Text = myHtml.Title;
            //步骤状态
            tbStep.Text = myHtml.Step;
            //任务描述  m-task-bd m-task-arc
            tbTaskDetail.Text = myHtml.TaskDetail;
        }

        private MyHtml LoadDetail(string url)
        {
            MyHtml myHtml = null;
            if (cacheHtml.ContainsKey(url))
            {
                myHtml = cacheHtml[url];
                return myHtml;
            }

            IHtmlDocument source = new JumonyParser().LoadDocument(url, System.Text.Encoding.GetEncoding("utf-8"));

            string title = source.Find(".m-task-main .m-detail-hd h2").ElementAt(0).InnerText();
            myHtml = new MyHtml()
            {
                Title = title.Substring(0, title.LastIndexOf("复制")),
                Step = source.Find(".m-task-main .pub-steps .step-on").ElementAt(0).InnerText(),
                TaskDetail = source.Find(".m-task-bd .m-task-arc").ElementAt(0).InnerText()
            };

            if (!cacheHtml.ContainsKey(url))
            {
                cacheHtml.Add(url, myHtml);
            }

            return myHtml;
        }
    }

    class MyHtml
    {
        public string Title { get; set; }
        public string Step { get; set; }
        public string TaskDetail { get; set; }
    }
}