using System;

enum CurrencyType
{
    USD,
    EUR,
    JPY,
    GBP
}
class Program
{
    static void Main()
    {
        Bai5();
        }
    static void Bai1()
    {
        // Nhập chỉ số điện
        Console.Write("Nhập chỉ số điện cũ (kWh): ");
        decimal chiSoCu = decimal.Parse(Console.ReadLine());

        Console.Write("Nhập chỉ số điện mới (kWh): ");
        decimal chiSoMoi = decimal.Parse(Console.ReadLine());

        // Kiểm tra chỉ số điện
        if (chiSoMoi < chiSoCu)
        {
            Console.WriteLine("Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số điện cũ.");
            return;
        }

        // Tính lượng điện tiêu thụ
        decimal luongdientieuthu = chiSoMoi - chiSoCu;

        // Đơn giá các bậc
        decimal donGiaBac1 = 1806;
        decimal donGiaBac2 = 1866;
        decimal donGiaBac3 = 2167;
        decimal donGiaBac4 = 2729;
        decimal donGiaBac5 = 3050;

        decimal tiendien = 0;
        decimal conlai = luongdientieuthu;

        // Bậc 1: 50 kWh đầu tiên
        if (conlai > 0)
        {
            decimal bac1 = Math.Min(conlai, 50);
            tiendien += bac1 * donGiaBac1;
            conlai -= bac1;
        }

        // Bậc 2: 50 kWh tiếp theo
        if (conlai > 0)
        {
            decimal bac2 = Math.Min(conlai, 50);
            tiendien += bac2 * donGiaBac2;
            conlai -= bac2;
        }

        // Bậc 3: 100 kWh tiếp theo
        if (conlai > 0)
        {
            decimal bac3 = Math.Min(conlai, 100);
            tiendien += bac3 * donGiaBac3;
            conlai -= bac3;
        }

        // Bậc 4: 100 kWh tiếp theo
        if (conlai > 0)
        {
            decimal bac4 = Math.Min(conlai, 100);
            tiendien += bac4 * donGiaBac4;
            conlai -= bac4;
        }

        // Bậc 5: Các kWh còn lại
        if (conlai > 0)
        {
            tiendien += conlai * donGiaBac5;
        }

        // Tính thuế VAT 8%
        decimal thueVAT = tiendien * 0.08m;
        decimal tongTien = tiendien + thueVAT;

        // In hóa đơn
        Console.WriteLine($"Số điện tiêu thụ: {luongdientieuthu} kWh");
        Console.WriteLine($"Tiền điện chưa thuế: {tiendien:#,##0} VNĐ");
        Console.WriteLine($"Thuế VAT (8%): {thueVAT:#,##0} VNĐ");
        Console.WriteLine($"Tổng thanh toán: {tongTien:#,##0} VNĐ");
    }
    static void Bai2()
    {
        //Nhập chiều cao
        Console.Write("Nhập chiều cao (m): ");
        double chieuCao = double.Parse(Console.ReadLine());

        //Nhập cân nặng
        Console.Write("Nhập cân nặng (kg): ");
        double canNang = double.Parse(Console.ReadLine());

        //Tính BMI
        double bmi = canNang / Math.Pow(chieuCao, 2);

        //Phân loại BMI
        string phanLoai;
        if (bmi < 18.5)
        {
            phanLoai = "Gầy (Thiếu cân)";
        }
        else if (bmi < 23.0)
        {
            phanLoai = "Bình thường (Lý tưởng)";
        }
        else if (bmi < 25.0)
        {
            phanLoai = "Thừa cân (Tiền béo phì)";
        }
        else
        {
            phanLoai = "Béo phì";
        }

        //Tính cân nặng lý tưởng
        double canNangtoithieu = 18.5 * Math.Pow(chieuCao, 2);
        double canNangtoida = 22.9 * Math.Pow(chieuCao, 2);

        //In kết quả
        Console.WriteLine($"Chỉ số BMI của bạn là: {bmi:F2}");
        Console.WriteLine($"Phân loại BMI: {phanLoai}");
        Console.WriteLine($"Cân nặng lý tưởng (kg): {canNangtoithieu:F2} - {canNangtoida:F2}");
    }

    static void Bai3()
{
    // Nhập số tiền VNĐ
    Console.Write("Nhập số tiền VNĐ: ");
    decimal tienVND = decimal.Parse(Console.ReadLine());

    // Chọn loại ngoại tệ
    Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
    int luaChon = int.Parse(Console.ReadLine());

    // Xác định loại tiền
    CurrencyType loaiTien;

    switch (luaChon)
    {
        case 1:
            loaiTien = CurrencyType.USD;
            break;

        case 2:
            loaiTien = CurrencyType.EUR;
            break;

        case 3:
            loaiTien = CurrencyType.JPY;
            break;

        case 4:
            loaiTien = CurrencyType.GBP;
            break;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            return;
    }

    // Xác định tỷ giá
    decimal tyGia = 0;

    switch (loaiTien)
    {
        case CurrencyType.USD:
            tyGia = 25400;
            break;

        case CurrencyType.EUR:
            tyGia = 27200;
            break;

        case CurrencyType.JPY:
            tyGia = 165;
            break;

        case CurrencyType.GBP:
            tyGia = 32100;
            break;
    }

    // Tính phí dịch vụ 0.5%
    decimal phiDichVu = tienVND * 0.005m;

    // Tính số tiền VNĐ thực tế để đổi
    decimal tienVNDThucTe = tienVND - phiDichVu;

    // Quy đổi sang ngoại tệ
    decimal tienNgoaiTe = tienVNDThucTe / tyGia;

    // In kết quả
    Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:#,##0} VNĐ");
    Console.WriteLine($"Số tiền VNĐ tính đổi: {tienVNDThucTe:#,##0} VNĐ");
    Console.WriteLine($"Số tiền {loaiTien} nhận được: {tienNgoaiTe:F2} {loaiTien}");
    }

    static void Bai4()
{
    // Nhập ngày sinh
    Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
    string ngaySinhText = Console.ReadLine();

    // Chuyển chuỗi thành DateTime
    DateTime ngaySinh;

    if (!DateTime.TryParseExact(
        ngaySinhText,
        "dd/MM/yyyy",
        null,
        System.Globalization.DateTimeStyles.None,
        out ngaySinh))
    {
        Console.WriteLine("Ngày sinh không hợp lệ.");
        return;
    }

    // Lấy ngày hiện tại
    DateTime homNay = DateTime.Now.Date;

    // Tính tuổi
    int tuoi = homNay.Year - ngaySinh.Year;

    if (homNay < ngaySinh.AddYears(tuoi))
    {
        tuoi--;
    }

    // Tính tổng số ngày đã sống
    TimeSpan daSong = homNay - ngaySinh;
    int tongSoNgay = (int)daSong.TotalDays;

    // Tìm sinh nhật tiếp theo
    DateTime sinhNhatTiepTheo = new DateTime(
        homNay.Year,
        ngaySinh.Month,
        ngaySinh.Day
    );

    if (sinhNhatTiepTheo < homNay)
    {
        sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
    }

    // Tính số ngày còn lại đến sinh nhật
    TimeSpan conLai = sinhNhatTiepTheo - homNay;
    int soNgayConLai = (int)conLai.TotalDays;

    // In kết quả
    Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
    Console.WriteLine($"Bạn đã sống tổng cộng: {tongSoNgay} ngày");
    Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai} ngày nữa");
}

static void Bai5()
    {
        //Nhập điểm và số tín chỉ
        Console.Write("Điểm Lập trình C#: ");
        double diem1 = double.Parse(Console.ReadLine());

        Console.Write("Số tín chỉ Lập trình C#: ");
        int tc1 = int.Parse(Console.ReadLine());

        Console.Write("Điểm Toán rời rạc: ");
        double diem2 = double.Parse(Console.ReadLine());

        Console.Write("Số tín chỉ Toán rời rạc: ");
        int tc2 = int.Parse(Console.ReadLine());

        Console.Write("Điểm Tiếng Anh: ");
        double diem3 = double.Parse(Console.ReadLine());

        Console.Write("Số tín chỉ Tiếng Anh: ");
        int tc3 = int.Parse(Console.ReadLine());

        //Tính điểm trung bình có trọng số
        double diemTB = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3) / (tc1 +tc2 +tc3);

        //Quy đổi điểm chữ
        char diemChu;

        if (diemTB >= 8.5)
        {
            diemChu = 'A';
        }
        else if (diemTB >= 7.0)
        {
            diemChu = 'B';
        }
        else if (diemTB >= 5.5)
        {
            diemChu = 'C';
        }
        else if (diemTB >= 4.0)
        {
            diemChu = 'D';
        }
        else
        {
            diemChu = 'F';
        }

        //Quy đổi sang thang điểm 4.0 (GPA)
        double gpa;
        
        if (diemChu == 'A')
        {
            gpa = 4.0;
        }
        else if (diemChu == 'B')
        {
            gpa = 3.0;
        }
        else if (diemChu == 'C')
        {
            gpa = 2.0;
        }
        else if (diemChu == 'D')
        {
            gpa = 1.0;
        }
        else
        {
            gpa = 0.0;
        }

        //Xếp loại học lực
        string xepLoai;

        if (diemChu =='A')
        {
            xepLoai = "Xuất sắc / Giỏi";
        }
        else if (diemChu == 'B')
        {
            xepLoai = "Khá";
        }
        else if (diemChu == 'C')
        {
            xepLoai = "Trung bình";
        }
        else if (diemChu == 'D')
        {
            xepLoai = "Yếu";
        }
        else
        {
            xepLoai = "Kém (Trượt)";
        }

        //In kết quả
        Console.WriteLine($"Điểm TB thang 10: {diemTB:F2}");
        Console.WriteLine($"Điểm chữ quy đổi: {diemChu}");
        Console.WriteLine($"Điểm GPA thang 4.0: {gpa:F1}");
        Console.WriteLine($"Xếp loại học lực: {xepLoai}");
    }
}
