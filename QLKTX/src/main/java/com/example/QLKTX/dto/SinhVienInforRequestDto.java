package com.example.QLKTX.dto;

import java.sql.Date;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.sql.Date;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class SinhVienInforRequestDto {
    private Integer sinhVienId;


    private String maSinhVien;


    private String hoTen;


    private Date ngaySinh;


    private String cccd;


    private String gioiTinh;


    private String soDienThoai;


    private String diaChi;


    private String email;


    private String trangThai;


    private String soPhong;

    private Integer nguoiDung;
}
