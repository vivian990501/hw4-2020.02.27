using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4_4_2020._02._28
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            var list_p = CreateData();
            dataGridView1.DataSource = list_p;
            var list_t = ProductTotalCalculation(list_p);
            dataGridView2.DataSource = list_t;
            Best(list_p, list_t);
        }

        private List<PerformanceTotalData> CreateData()
        {
            char[] splits = new char[] { ',' };
            string fileName = "Performance.csv";
            List<PerformanceData> result_1 = new List<PerformanceData>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(splits);
                    var performance = new PerformanceData
                    {
                        SalesName = items[0],
                        Atomicbrush = int.Parse(items[1]),
                        Pencil = int.Parse(items[2]),
                        Eraser = int.Parse(items[3]),
                        Ruler = int.Parse(items[4]),
                        Liquid = int.Parse(items[5])
                    };

                    result_1.Add(performance);
                }
            }
            int s = 0;
            var result_s = result_1.GroupBy((x) => x.SalesName);
            int[] ss = new int[3];
            int j = 0;
            foreach (var item in result_s)
            {
                
                s = item.Sum((x) => x.Atomicbrush) * 12 + item.Sum((x) => x.Pencil) * 16 + item.Sum((x) => x.Eraser) * 10 + item.Sum((x) => x.Ruler) * 14 + item.Sum((x) => x.Liquid) * 15;
                ss[j] = s;
                j++;
            }
            int k = 0;
            List<PerformanceTotalData> result = new List<PerformanceTotalData>();
            foreach (var item in result_1)
            {
                var p = new PerformanceTotalData()
                {
                    SalesName = item.SalesName,
                    Atomicbrush = item.Atomicbrush,
                    Eraser = item.Eraser,
                    Ruler = item.Ruler,
                    Pencil = item.Pencil,
                    Liquid = item.Liquid,
                    SalesTotal=ss[k]
                };
                k++;

                result.Add(p);
            }
            
            return result;
        }
        private List<ProductTotalData> ProductTotalCalculation(List<PerformanceTotalData> list)
        {
            List<ProductTotalData> result = new List<ProductTotalData>();
            var product = new ProductTotalData
            {
                Atomicbrush_t = list.Sum((x) => x.Atomicbrush) * 12,
                Pencil_t = list.Sum((x) => x.Pencil) * 16,
                Eraser_t = list.Sum((x) => x.Eraser) * 10,
                Ruler_t = list.Sum((x) => x.Ruler) * 14,
                Liquid_t = list.Sum((x) => x.Liquid) * 15,
            };
            result.Add(product);

            return result;
        }

        private void Best(List<PerformanceTotalData>list_1, List<ProductTotalData>list_2)
        {
            var bm = list_1.First((x) => x.SalesTotal == list_1.Max((y)=>y.SalesTotal));
            label1.Text ="最佳業務員 : "+ bm.SalesName.ToString();
            var list = new List<int>();
            foreach(var item in list_2)
            {
                list.Add(item.Atomicbrush_t);
                list.Add(item.Pencil_t);
                list.Add(item.Eraser_t);
                list.Add(item.Ruler_t);
                list.Add(item.Liquid_t);
            }
            int pm = 0;
            foreach (var item in list)
            {
                if(item>pm)
                {
                    pm = item;
                }
            }
            var pm_i = list.FindIndex((x)=>x==pm);
            switch(pm_i)
            {
                case 0:
                    label2.Text = "最佳產品 : 原子筆";
                    break;
                case 1:
                    label2.Text = "最佳產品 : 鉛筆";
                    break;
                case 2:
                    label2.Text = "最佳產品 : 橡皮擦";
                    break;
                case 3:
                    label2.Text = "最佳產品 : 直尺";
                    break;
                case 4:
                    label2.Text = "最佳產品 : 立可白";
                    break;
                default:
                    break;
            }
        }

    }
}
