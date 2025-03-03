// Decompiled with JetBrains decompiler
// Type: Eis.Eca.ZReport.Rpt_InAn.xReport_LyLichHoatDong_V3
// Assembly: Eis.Eca.ZReport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2D39B07C-ABFE-4737-938C-E01DA5194F75
// Assembly location: D:\HK241\Hdsv_Tool_BanGiao_Clone_TuanBC\Eis.Eca.ZReport.dll

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Eis.Eca.DataInfo.QL_Report;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

#nullable disable
namespace Eis.Eca.ZReport.Rpt_InAn
{
  public class xReport_LyLichHoatDong_V3 : XtraReport
  {
    private int currentLine;
    private IContainer components = (IContainer) null;
    private DetailBand Detail;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRPageInfo xrPageInfo1;
    private XRLabel tbcDiaDiem_Short;
    private XRLabel tbcNgayBdThucHien;
    private XRLabel tbcHoatDongTen_Short;
    private ReportFooterBand ReportFooter;
    private XRPanel xrPanel2;
    private XRLabel lblNguoiKy_Ten;
    private XRLabel lblNguoiKy_ChucVu;
    private XRLabel xrLabel20;
    private XRLabel lblNgayIn_Nam;
    private XRLabel lblNgayIn_Thang;
    private XRLabel lblNgayIn_Ngay;
    private XRLabel xrLabel16;
    private XRLabel xrLabel7;
    private XRLabel xrLabel2;
    private XRLabel xrLabel10;
    private XRLabel xrLabel11;
    private XRLabel lblTongHd;
    private XRLabel lblTongNgayCTXH;
    private PageHeaderBand PageHeader;
    private XRPanel xrPanel1;
    private XRLabel lblMaPDK;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel3;
    private XRLabel lblUserFacultyName;
    private XRLabel lblUserID;
    private XRLabel xrLabel1;
    private XRLabel xrLabel4;
    private XRLabel xrLabel23;
    private XRLabel lblUserFullName;
    private XRLabel xrLabel15;
    private XRLabel lblUserNgaySinh;
    private GroupHeaderBand GroupHeader2;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell tbcSoNgayThucHien;
    private XRTableCell tbcHoatDongID;
    private XRLine xrLine1;
    private XRTableCell tbcSoNgayQuyDoi;
    private PageFooterBand PageFooter;
    private XRRichText xrRichText2;
    private XRLabel lblUserID_Header;

    public xReport_LyLichHoatDong_V3() => this.InitializeComponent();

    public xReport_LyLichHoatDong_V3(LyLichHoatDong one)
    {
      this.InitializeComponent();
      try
      {
        this.lblMaPDK.Text = "";
        this.lblUserID_Header.Text = one.UserID;
        this.lblUserID.Text = one.UserID;
        this.lblUserFullName.Text = one.UserFullName;
        this.lblUserNgaySinh.Text = one.NgaySinh_String;
        this.lblUserFacultyName.Text = one.FacultyName;
        this.lblNgayIn_Nam.Text = DateTime.Now.Year.ToString();
        this.lblNgayIn_Thang.Text = DateTime.Now.Month.ToString();
        this.lblNgayIn_Ngay.Text = DateTime.Now.Day.ToString();
        this.lblNguoiKy_Ten.Text = "";
        this.lblTongHd.Text = one.TongSoHdThamGia;
        this.lblTongNgayCTXH.Text = one.TongSoNgayCTXH;
        this.tbcHoatDongID.DataBindings.Add("Text", this.DataSource, "HoatDongID");
        this.tbcHoatDongTen_Short.DataBindings.Add("Text", this.DataSource, "HoatDongTen_Short");
        this.tbcDiaDiem_Short.DataBindings.Add("Text", this.DataSource, "DiaDiem_Short");
        this.tbcNgayBdThucHien.DataBindings.Add("Text", this.DataSource, "NgayBdThucHien", "{0:MM/yyyy}");
        this.tbcSoNgayThucHien.DataBindings.Add("Text", this.DataSource, "SoNgayThucHien");
        this.tbcSoNgayQuyDoi.DataBindings.Add("Text", this.DataSource, "SoNgayQuyDoi");
      }
      catch (Exception ex)
      {
      }
    }

    private void xReport_LyLichHoatDong_BeforePrint(object sender, PrintEventArgs e)
    {
      this.currentLine = 0;
    }

    private void xrTableCell2_BeforePrint(object sender, PrintEventArgs e)
    {
      (sender as XRLabel).Text = (++this.currentLine).ToString();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (xReport_LyLichHoatDong_V3));
      this.Detail = new DetailBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.tbcHoatDongID = new XRTableCell();
      this.xrTableCell3 = new XRTableCell();
      this.xrLine1 = new XRLine();
      this.tbcHoatDongTen_Short = new XRLabel();
      this.tbcNgayBdThucHien = new XRLabel();
      this.tbcDiaDiem_Short = new XRLabel();
      this.tbcSoNgayThucHien = new XRTableCell();
      this.tbcSoNgayQuyDoi = new XRTableCell();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.xrPageInfo1 = new XRPageInfo();
      this.ReportFooter = new ReportFooterBand();
      this.xrPanel2 = new XRPanel();
      this.lblNguoiKy_Ten = new XRLabel();
      this.lblNguoiKy_ChucVu = new XRLabel();
      this.xrLabel20 = new XRLabel();
      this.lblNgayIn_Nam = new XRLabel();
      this.lblNgayIn_Thang = new XRLabel();
      this.lblNgayIn_Ngay = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.lblTongHd = new XRLabel();
      this.lblTongNgayCTXH = new XRLabel();
      this.PageHeader = new PageHeaderBand();
      this.xrPanel1 = new XRPanel();
      this.lblMaPDK = new XRLabel();
      this.lblUserID_Header = new XRLabel();
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrLabel3 = new XRLabel();
      this.lblUserFacultyName = new XRLabel();
      this.lblUserID = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrLabel23 = new XRLabel();
      this.lblUserFullName = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.lblUserNgaySinh = new XRLabel();
      this.GroupHeader2 = new GroupHeaderBand();
      this.xrTable2 = new XRTable();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.PageFooter = new PageFooterBand();
      this.xrRichText2 = new XRRichText();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrRichText2.BeginInit();
      this.BeginInit();
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.Detail.Dpi = 254f;
      this.Detail.HeightF = 128.9167f;
      this.Detail.KeepTogether = true;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
      this.Detail.TextAlignment = TextAlignment.TopLeft;
      this.xrTable1.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTable1.Dpi = 254f;
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(1791f, 128.9167f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell2,
        this.tbcHoatDongID,
        this.xrTableCell3,
        this.tbcSoNgayThucHien,
        this.tbcSoNgayQuyDoi
      });
      this.xrTableRow1.Dpi = 254f;
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell2.Dpi = 254f;
      this.xrTableCell2.Font = new Font("Times New Roman", 12f);
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.18994212633139973;
      this.xrTableCell2.BeforePrint += new PrintEventHandler(this.xrTableCell2_BeforePrint);
      this.tbcHoatDongID.Dpi = 254f;
      this.tbcHoatDongID.Font = new Font("Times New Roman", 12f);
      this.tbcHoatDongID.Name = "tbcHoatDongID";
      this.tbcHoatDongID.StylePriority.UseFont = false;
      this.tbcHoatDongID.StylePriority.UseTextAlignment = false;
      this.tbcHoatDongID.Text = "tbcHoatDongID";
      this.tbcHoatDongID.TextAlignment = TextAlignment.MiddleCenter;
      this.tbcHoatDongID.Weight = 0.49720422071911113;
      this.xrTableCell3.Controls.AddRange(new XRControl[4]
      {
        (XRControl) this.xrLine1,
        (XRControl) this.tbcHoatDongTen_Short,
        (XRControl) this.tbcNgayBdThucHien,
        (XRControl) this.tbcDiaDiem_Short
      });
      this.xrTableCell3.Dpi = 254f;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Weight = 1.940958990182573;
      this.xrLine1.Borders = BorderSide.None;
      this.xrLine1.Dpi = 254f;
      this.xrLine1.LineWidth = 3;
      this.xrLine1.LocationFloat = new PointFloat(162.2275f, 60.85409f);
      this.xrLine1.Name = "xrLine1";
      this.xrLine1.SizeF = new SizeF(18.52081f, 66.146f);
      this.xrLine1.StylePriority.UseBorders = false;
      this.tbcHoatDongTen_Short.Borders = BorderSide.None;
      this.tbcHoatDongTen_Short.Dpi = 254f;
      this.tbcHoatDongTen_Short.Font = new Font("Times New Roman", 12f, FontStyle.Bold);
      this.tbcHoatDongTen_Short.LocationFloat = new PointFloat(3.051758E-05f, 0.0f);
      this.tbcHoatDongTen_Short.Name = "tbcHoatDongTen_Short";
      this.tbcHoatDongTen_Short.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.tbcHoatDongTen_Short.SizeF = new SizeF(1116.419f, 60.85419f);
      this.tbcHoatDongTen_Short.StylePriority.UseBorders = false;
      this.tbcHoatDongTen_Short.StylePriority.UseFont = false;
      this.tbcHoatDongTen_Short.StylePriority.UseTextAlignment = false;
      this.tbcHoatDongTen_Short.Text = "tbcHoatDongTen_Short";
      this.tbcHoatDongTen_Short.TextAlignment = TextAlignment.MiddleLeft;
      this.tbcNgayBdThucHien.Borders = BorderSide.None;
      this.tbcNgayBdThucHien.Dpi = 254f;
      this.tbcNgayBdThucHien.Font = new Font("Times New Roman", 12f);
      this.tbcNgayBdThucHien.LocationFloat = new PointFloat(3.051758E-05f, 60.85417f);
      this.tbcNgayBdThucHien.Name = "tbcNgayBdThucHien";
      this.tbcNgayBdThucHien.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.tbcNgayBdThucHien.SizeF = new SizeF(162.2275f, 66.14592f);
      this.tbcNgayBdThucHien.StylePriority.UseBorders = false;
      this.tbcNgayBdThucHien.StylePriority.UseFont = false;
      this.tbcNgayBdThucHien.StylePriority.UseTextAlignment = false;
      this.tbcNgayBdThucHien.TextAlignment = TextAlignment.MiddleLeft;
      this.tbcDiaDiem_Short.Borders = BorderSide.None;
      this.tbcDiaDiem_Short.Dpi = 254f;
      this.tbcDiaDiem_Short.Font = new Font("Times New Roman", 12f, FontStyle.Italic);
      this.tbcDiaDiem_Short.LocationFloat = new PointFloat(193.9777f, 60.85417f);
      this.tbcDiaDiem_Short.Name = "tbcDiaDiem_Short";
      this.tbcDiaDiem_Short.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.tbcDiaDiem_Short.SizeF = new SizeF(922.4414f, 66.14586f);
      this.tbcDiaDiem_Short.StylePriority.UseBorders = false;
      this.tbcDiaDiem_Short.StylePriority.UseFont = false;
      this.tbcDiaDiem_Short.StylePriority.UseTextAlignment = false;
      this.tbcDiaDiem_Short.Text = "tbcDiaDiem_Short";
      this.tbcDiaDiem_Short.TextAlignment = TextAlignment.MiddleLeft;
      this.tbcSoNgayThucHien.Dpi = 254f;
      this.tbcSoNgayThucHien.Font = new Font("Times New Roman", 12f);
      this.tbcSoNgayThucHien.Name = "tbcSoNgayThucHien";
      this.tbcSoNgayThucHien.StylePriority.UseFont = false;
      this.tbcSoNgayThucHien.StylePriority.UseTextAlignment = false;
      this.tbcSoNgayThucHien.Text = "tbcSoNgayThucHien";
      this.tbcSoNgayThucHien.TextAlignment = TextAlignment.MiddleCenter;
      this.tbcSoNgayThucHien.Weight = 0.19880592796019908;
      this.tbcSoNgayQuyDoi.Dpi = 254f;
      this.tbcSoNgayQuyDoi.Font = new Font("Times New Roman", 12f);
      this.tbcSoNgayQuyDoi.Name = "tbcSoNgayQuyDoi";
      this.tbcSoNgayQuyDoi.StylePriority.UseFont = false;
      this.tbcSoNgayQuyDoi.StylePriority.UseTextAlignment = false;
      this.tbcSoNgayQuyDoi.Text = "tbcSoNgayQuyDoi";
      this.tbcSoNgayQuyDoi.TextAlignment = TextAlignment.MiddleCenter;
      this.tbcSoNgayQuyDoi.Weight = 0.17308873480671685;
      this.TopMargin.Dpi = 254f;
      this.TopMargin.HeightF = 156f;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
      this.TopMargin.TextAlignment = TextAlignment.TopLeft;
      this.BottomMargin.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrPageInfo1
      });
      this.BottomMargin.Dpi = 254f;
      this.BottomMargin.HeightF = 198f;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
      this.BottomMargin.TextAlignment = TextAlignment.TopLeft;
      this.xrPageInfo1.Dpi = 254f;
      this.xrPageInfo1.Font = new Font("Times New Roman", 13f);
      this.xrPageInfo1.LocationFloat = new PointFloat(732.8955f, 13.16328f);
      this.xrPageInfo1.Name = "xrPageInfo1";
      this.xrPageInfo1.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrPageInfo1.SizeF = new SizeF(254f, 58.42f);
      this.xrPageInfo1.StylePriority.UseFont = false;
      this.xrPageInfo1.StylePriority.UseTextAlignment = false;
      this.xrPageInfo1.TextAlignment = TextAlignment.TopCenter;
      this.ReportFooter.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrPanel2
      });
      this.ReportFooter.Dpi = 254f;
      this.ReportFooter.HeightF = 627f;
      this.ReportFooter.KeepTogether = true;
      this.ReportFooter.Name = "ReportFooter";
      this.ReportFooter.PageBreak = PageBreak.AfterBand;
      this.xrPanel2.Controls.AddRange(new XRControl[13]
      {
        (XRControl) this.lblNguoiKy_Ten,
        (XRControl) this.lblNguoiKy_ChucVu,
        (XRControl) this.xrLabel20,
        (XRControl) this.lblNgayIn_Nam,
        (XRControl) this.lblNgayIn_Thang,
        (XRControl) this.lblNgayIn_Ngay,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel11,
        (XRControl) this.lblTongHd,
        (XRControl) this.lblTongNgayCTXH
      });
      this.xrPanel2.Dpi = 254f;
      this.xrPanel2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPanel2.Name = "xrPanel2";
      this.xrPanel2.SizeF = new SizeF(1791f, 626.9999f);
      this.lblNguoiKy_Ten.Dpi = 254f;
      this.lblNguoiKy_Ten.Font = new Font("Times New Roman", 13f);
      this.lblNguoiKy_Ten.KeepTogether = true;
      this.lblNguoiKy_Ten.LocationFloat = new PointFloat(867.339f, 543.5797f);
      this.lblNguoiKy_Ten.Name = "lblNguoiKy_Ten";
      this.lblNguoiKy_Ten.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblNguoiKy_Ten.SizeF = new SizeF(894.5568f, 58.41992f);
      this.lblNguoiKy_Ten.StylePriority.UseFont = false;
      this.lblNguoiKy_Ten.StylePriority.UseTextAlignment = false;
      this.lblNguoiKy_Ten.Text = "lblNguoiKy_Ten";
      this.lblNguoiKy_Ten.TextAlignment = TextAlignment.TopCenter;
      this.lblNguoiKy_ChucVu.Dpi = 254f;
      this.lblNguoiKy_ChucVu.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblNguoiKy_ChucVu.KeepTogether = true;
      this.lblNguoiKy_ChucVu.LocationFloat = new PointFloat(867.3389f, 352.5307f);
      this.lblNguoiKy_ChucVu.Name = "lblNguoiKy_ChucVu";
      this.lblNguoiKy_ChucVu.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblNguoiKy_ChucVu.SizeF = new SizeF(894.5567f, 58.41998f);
      this.lblNguoiKy_ChucVu.StylePriority.UseFont = false;
      this.lblNguoiKy_ChucVu.StylePriority.UseTextAlignment = false;
      this.lblNguoiKy_ChucVu.Text = "TRƯỞNG PHÒNG CTSV";
      this.lblNguoiKy_ChucVu.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel20.Dpi = 254f;
      this.xrLabel20.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel20.KeepTogether = true;
      this.xrLabel20.LocationFloat = new PointFloat(867.339f, 732.8955f);
      this.xrLabel20.Name = "xrLabel20";
      this.xrLabel20.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel20.SizeF = new SizeF(923.6609f, 58.42001f);
      this.xrLabel20.StylePriority.UseFont = false;
      this.xrLabel20.StylePriority.UseTextAlignment = false;
      this.xrLabel20.Text = "Trần Việt Toàn";
      this.xrLabel20.TextAlignment = TextAlignment.TopCenter;
      this.lblNgayIn_Nam.Dpi = 254f;
      this.lblNgayIn_Nam.Font = new Font("Times New Roman", 13f);
      this.lblNgayIn_Nam.KeepTogether = true;
      this.lblNgayIn_Nam.LocationFloat = new PointFloat(1613.464f, 235.6906f);
      this.lblNgayIn_Nam.Name = "lblNgayIn_Nam";
      this.lblNgayIn_Nam.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblNgayIn_Nam.SizeF = new SizeF(135.2013f, 58.41997f);
      this.lblNgayIn_Nam.StylePriority.UseFont = false;
      this.lblNgayIn_Nam.Text = "lblNgayIn_Nam";
      this.lblNgayIn_Thang.Dpi = 254f;
      this.lblNgayIn_Thang.Font = new Font("Times New Roman", 13f);
      this.lblNgayIn_Thang.KeepTogether = true;
      this.lblNgayIn_Thang.LocationFloat = new PointFloat(1422.435f, 235.6906f);
      this.lblNgayIn_Thang.Name = "lblNgayIn_Thang";
      this.lblNgayIn_Thang.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblNgayIn_Thang.SizeF = new SizeF(84.93091f, 58.42003f);
      this.lblNgayIn_Thang.StylePriority.UseFont = false;
      this.lblNgayIn_Thang.Text = "lblNgayIn_Thang";
      this.lblNgayIn_Ngay.Dpi = 254f;
      this.lblNgayIn_Ngay.Font = new Font("Times New Roman", 13f);
      this.lblNgayIn_Ngay.KeepTogether = true;
      this.lblNgayIn_Ngay.LocationFloat = new PointFloat(1213.944f, 235.6906f);
      this.lblNgayIn_Ngay.Name = "lblNgayIn_Ngay";
      this.lblNgayIn_Ngay.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblNgayIn_Ngay.SizeF = new SizeF(76.99341f, 58.42f);
      this.lblNgayIn_Ngay.StylePriority.UseFont = false;
      this.lblNgayIn_Ngay.Text = "lblNgayIn_Ngay";
      this.xrLabel16.Dpi = 254f;
      this.xrLabel16.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel16.KeepTogether = true;
      this.xrLabel16.LocationFloat = new PointFloat(1507.367f, 235.6906f);
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel16.SizeF = new SizeF(106.0975f, 58.42f);
      this.xrLabel16.StylePriority.UseFont = false;
      this.xrLabel16.Text = "năm";
      this.xrLabel7.Dpi = 254f;
      this.xrLabel7.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel7.KeepTogether = true;
      this.xrLabel7.LocationFloat = new PointFloat(1288.292f, 235.6906f);
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel7.SizeF = new SizeF(134.1445f, 58.41997f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.Text = "tháng";
      this.xrLabel2.Dpi = 254f;
      this.xrLabel2.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel2.KeepTogether = true;
      this.xrLabel2.LocationFloat = new PointFloat(893.7974f, 235.6906f);
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel2.SizeF = new SizeF(320.1458f, 58.42f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.Text = "Tp HCM, Ngày";
      this.xrLabel10.Dpi = 254f;
      this.xrLabel10.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel10.KeepTogether = true;
      this.xrLabel10.LocationFloat = new PointFloat(95.25f, 50.27083f);
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel10.SizeF = new SizeF(577.8499f, 58.41999f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.Text = "Tổng hoạt động đã tham gia:";
      this.xrLabel11.Dpi = 254f;
      this.xrLabel11.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel11.KeepTogether = true;
      this.xrLabel11.LocationFloat = new PointFloat(95.25f, 121.7083f);
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel11.SizeF = new SizeF(921.8079f, 58.42001f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.Text = "Tổng ngày công tác xã hội đã được công nhận:";
      this.lblTongHd.Dpi = 254f;
      this.lblTongHd.Font = new Font("Times New Roman", 13f, FontStyle.Bold | FontStyle.Italic);
      this.lblTongHd.KeepTogether = true;
      this.lblTongHd.LocationFloat = new PointFloat(673.0999f, 50.27083f);
      this.lblTongHd.Name = "lblTongHd";
      this.lblTongHd.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblTongHd.SizeF = new SizeF(222.25f, 58.41999f);
      this.lblTongHd.StylePriority.UseFont = false;
      this.lblTongHd.Text = "lblTongHd";
      this.lblTongNgayCTXH.Dpi = 254f;
      this.lblTongNgayCTXH.Font = new Font("Times New Roman", 13f, FontStyle.Bold | FontStyle.Italic);
      this.lblTongNgayCTXH.KeepTogether = true;
      this.lblTongNgayCTXH.LocationFloat = new PointFloat(1017.058f, 121.7083f);
      this.lblTongNgayCTXH.Name = "lblTongNgayCTXH";
      this.lblTongNgayCTXH.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblTongNgayCTXH.SizeF = new SizeF(173.831f, 58.42003f);
      this.lblTongNgayCTXH.StylePriority.UseFont = false;
      this.lblTongNgayCTXH.Text = "lblTongNgayCTXH";
      this.PageHeader.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrPanel1
      });
      this.PageHeader.Dpi = 254f;
      this.PageHeader.HeightF = 487.7857f;
      this.PageHeader.Name = "PageHeader";
      this.xrPanel1.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.lblMaPDK,
        (XRControl) this.lblUserID_Header
      });
      this.xrPanel1.Dpi = 254f;
      this.xrPanel1.LocationFloat = new PointFloat(31.75f, 0.0f);
      this.xrPanel1.Name = "xrPanel1";
      this.xrPanel1.SizeF = new SizeF(1740.6f, 285.75f);
      this.lblMaPDK.Dpi = 254f;
      this.lblMaPDK.Font = new Font("Times New Roman", 10f, FontStyle.Bold);
      this.lblMaPDK.LocationFloat = new PointFloat(1256.148f, 187.4309f);
      this.lblMaPDK.Name = "lblMaPDK";
      this.lblMaPDK.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblMaPDK.SizeF = new SizeF(484.4519f, 50f);
      this.lblMaPDK.StylePriority.UseFont = false;
      this.lblMaPDK.StylePriority.UseTextAlignment = false;
      this.lblMaPDK.Text = "lblMaPDK";
      this.lblMaPDK.TextAlignment = TextAlignment.MiddleRight;
      this.lblUserID_Header.Dpi = 254f;
      this.lblUserID_Header.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblUserID_Header.LocationFloat = new PointFloat(1326.792f, 237.4309f);
      this.lblUserID_Header.Name = "lblUserID_Header";
      this.lblUserID_Header.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblUserID_Header.SizeF = new SizeF(407.4581f, 39.89912f);
      this.lblUserID_Header.StylePriority.UseFont = false;
      this.lblUserID_Header.StylePriority.UseTextAlignment = false;
      this.lblUserID_Header.Text = "xrLabel6";
      this.lblUserID_Header.TextAlignment = TextAlignment.MiddleRight;
      this.GroupHeader1.Controls.AddRange(new XRControl[9]
      {
        (XRControl) this.xrLabel3,
        (XRControl) this.lblUserFacultyName,
        (XRControl) this.lblUserID,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLabel23,
        (XRControl) this.lblUserFullName,
        (XRControl) this.xrLabel15,
        (XRControl) this.lblUserNgaySinh
      });
      this.GroupHeader1.Dpi = 254f;
      this.GroupHeader1.HeightF = 267f;
      this.GroupHeader1.Level = 1;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrLabel3.Dpi = 254f;
      this.xrLabel3.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(31.75f, (float) sbyte.MaxValue);
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel3.SizeF = new SizeF(243.4167f, 58.41998f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.Text = "Ngày sinh:";
      this.lblUserFacultyName.Dpi = 254f;
      this.lblUserFacultyName.Font = new Font("Times New Roman", 13f, FontStyle.Bold | FontStyle.Italic);
      this.lblUserFacultyName.LocationFloat = new PointFloat(1190.889f, (float) sbyte.MaxValue);
      this.lblUserFacultyName.Name = "lblUserFacultyName";
      this.lblUserFacultyName.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblUserFacultyName.SizeF = new SizeF(581.4609f, 58.41998f);
      this.lblUserFacultyName.StylePriority.UseFont = false;
      this.lblUserFacultyName.Text = "lblUserFacultyName";
      this.lblUserID.Dpi = 254f;
      this.lblUserID.Font = new Font("Times New Roman", 13f, FontStyle.Bold | FontStyle.Italic);
      this.lblUserID.LocationFloat = new PointFloat(1190.889f, 31.75f);
      this.lblUserID.Name = "lblUserID";
      this.lblUserID.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblUserID.SizeF = new SizeF(378.3542f, 58.41998f);
      this.lblUserID.StylePriority.UseFont = false;
      this.lblUserID.Text = "lblUserID";
      this.xrLabel1.Dpi = 254f;
      this.xrLabel1.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(31.75f, 31.75f);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel1.SizeF = new SizeF(243.4167f, 58.41998f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.Text = "Họ tên SV:";
      this.xrLabel4.Dpi = 254f;
      this.xrLabel4.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel4.LocationFloat = new PointFloat(955.4099f, (float) sbyte.MaxValue);
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel4.SizeF = new SizeF(235.4789f, 58.42004f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.Text = "Khoa-Lớp:";
      this.xrLabel23.Dpi = 254f;
      this.xrLabel23.Font = new Font("Times New Roman", 9f);
      this.xrLabel23.LocationFloat = new PointFloat(1553.104f, 208.58f);
      this.xrLabel23.Name = "xrLabel23";
      this.xrLabel23.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel23.SizeF = new SizeF(224.8959f, 58.41997f);
      this.xrLabel23.StylePriority.UseFont = false;
      this.xrLabel23.StylePriority.UseTextAlignment = false;
      this.xrLabel23.Text = "@BK2012";
      this.xrLabel23.TextAlignment = TextAlignment.TopRight;
      this.lblUserFullName.Dpi = 254f;
      this.lblUserFullName.Font = new Font("Times New Roman", 13f, FontStyle.Bold | FontStyle.Italic);
      this.lblUserFullName.LocationFloat = new PointFloat(275.1667f, 31.75f);
      this.lblUserFullName.Name = "lblUserFullName";
      this.lblUserFullName.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblUserFullName.SizeF = new SizeF(679.9789f, 58.41998f);
      this.lblUserFullName.StylePriority.UseFont = false;
      this.lblUserFullName.Text = "lblUserFullName";
      this.xrLabel15.Dpi = 254f;
      this.xrLabel15.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrLabel15.LocationFloat = new PointFloat(955.4099f, 31.75f);
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.xrLabel15.SizeF = new SizeF(235.479f, 58.41998f);
      this.xrLabel15.StylePriority.UseFont = false;
      this.xrLabel15.Text = "Mã số SV:";
      this.lblUserNgaySinh.Dpi = 254f;
      this.lblUserNgaySinh.Font = new Font("Times New Roman", 13f, FontStyle.Bold | FontStyle.Italic);
      this.lblUserNgaySinh.LocationFloat = new PointFloat(275.1667f, (float) sbyte.MaxValue);
      this.lblUserNgaySinh.Name = "lblUserNgaySinh";
      this.lblUserNgaySinh.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
      this.lblUserNgaySinh.SizeF = new SizeF(640.2913f, 58.41998f);
      this.lblUserNgaySinh.StylePriority.UseFont = false;
      this.lblUserNgaySinh.Text = "lblUserNgaySinh";
      this.GroupHeader2.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable2
      });
      this.GroupHeader2.Dpi = 254f;
      this.GroupHeader2.HeightF = 114.0884f;
      this.GroupHeader2.Name = "GroupHeader2";
      this.GroupHeader2.RepeatEveryPage = true;
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.Dpi = 254f;
      this.xrTable2.Font = new Font("Times New Roman", 13f);
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow2
      });
      this.xrTable2.SizeF = new SizeF(1791f, 114.0884f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseFont = false;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell5,
        this.xrTableCell6,
        this.xrTableCell7,
        this.xrTableCell1,
        this.xrTableCell8
      });
      this.xrTableRow2.Dpi = 254f;
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell5.Dpi = 254f;
      this.xrTableCell5.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "STT";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.21319784561389593;
      this.xrTableCell6.Dpi = 254f;
      this.xrTableCell6.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Mã hoạt động";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 0.55808008570153078;
      this.xrTableCell7.Dpi = 254f;
      this.xrTableCell7.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Thông tin chi tiết";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 2.1786029608224551;
      this.xrTableCell1.Dpi = 254f;
      this.xrTableCell1.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Thời lượng";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 0.22314696871215253;
      this.xrTableCell8.Dpi = 254f;
      this.xrTableCell8.Font = new Font("Times New Roman", 13f, FontStyle.Bold);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "Quy đổi";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 0.19428104024450904;
      this.PageFooter.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrRichText2
      });
      this.PageFooter.Dpi = 254f;
      this.PageFooter.HeightF = 119.2742f;
      this.PageFooter.Name = "PageFooter";
      this.xrRichText2.Dpi = 254f;
      this.xrRichText2.Font = new Font("Times New Roman", 9f, FontStyle.Italic);
      this.xrRichText2.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrRichText2.Name = "xrRichText2";
      this.xrRichText2.SerializableRtfString = componentResourceManager.GetString("xrRichText2.SerializableRtfString");
      this.xrRichText2.SizeF = new SizeF(955.1455f, 119.2742f);
      this.xrRichText2.StylePriority.UseFont = false;
      this.Bands.AddRange(new Band[8]
      {
        (Band) this.Detail,
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportFooter,
        (Band) this.PageHeader,
        (Band) this.GroupHeader1,
        (Band) this.GroupHeader2,
        (Band) this.PageFooter
      });
      this.DataSourceSchema = componentResourceManager.GetString("$this.DataSourceSchema");
      this.Dpi = 254f;
      this.Margins = new Margins(146, 164, 156, 198);
      this.PageHeight = 2969;
      this.PageWidth = 2101;
      this.PaperKind = PaperKind.A4;
      this.ReportUnit = ReportUnit.TenthsOfAMillimeter;
      this.SnapGridSize = 31.75f;
      this.Version = "12.1";
      this.BeforePrint += new PrintEventHandler(this.xReport_LyLichHoatDong_BeforePrint);
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrRichText2.EndInit();
      this.EndInit();
    }
  }
}
