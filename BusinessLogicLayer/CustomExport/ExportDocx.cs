using BusinessLogicLayer.Interface;
using ChamThiTuyenSinh10;
using Entities;
using Novacode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ExportDocx : DocxHelper
    {
       public static string CreateClassTemplate(string filename, Dictionary<string, string> dictionaryData, IList<dynamic> data)
        {
            string res = "";
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                dynamic item = data[i];
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(item.GetType().GetProperty("TenSP").GetValue(item, null));
                                newRow.Cells[2].Paragraphs.First().Append(item.GetType().GetProperty("DVT").GetValue(item, null));
                                newRow.Cells[3].Paragraphs.First().Append(item.GetType().GetProperty("SoLuong").GetValue(item, null).ToString());
                                newRow.Cells[4].Paragraphs.First().Append(item.GetType().GetProperty("DonGia").GetValue(item, null).ToString());;
                                newRow.Cells[5].Paragraphs.First().Append(item.GetType().GetProperty("Tong").GetValue(item, null).ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }
        public static string CreateChiTietTemplate(string filename, Dictionary<string, string> dictionaryData, IList<ETTChiTietHoaDon> data)
        {
            string res = "";
            IProductBUL product = new ProductBUL();
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                string tensp = product.getAll().FirstOrDefault(sp => sp.MSP == data[i].Ma_san_pham)?.TSP;
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].Ma_san_pham.ToString());
                                newRow.Cells[2].Paragraphs.First().Append(data[i].So_luong.ToString());
                                newRow.Cells[3].Paragraphs.First().Append(data[i].Gia_ban.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }
        public static string CreatePhieuNhapTemplate(string filename, Dictionary<string, string> dictionaryData, IList<ETTCTPN> data)
        {
            string res = "";
            IProductBUL product = new ProductBUL();
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                string tenSP  = product.getAll().FirstOrDefault(sanpham => sanpham.MSP == data[i].MaSanPham)?.TSP;
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(tenSP);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].SoLuong.ToString() + "   X");
                                newRow.Cells[3].Paragraphs.First().Append(data[i].DonGia.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }
    }
}
