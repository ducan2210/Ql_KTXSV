package com.example.QLKTX.service;

import com.example.QLKTX.dto.RegisterRequestDto;
import com.example.QLKTX.dto.LoginRequestDto;
import com.example.QLKTX.dto.SinhVienInforRequestDto;
import com.example.QLKTX.entity.SinhVien;

import java.util.List;

public interface ISinhVienService {
    void save(SinhVien sinhVien);
    SinhVien register(RegisterRequestDto registerRequest);
    SinhVien getSinhVienbyMaSinhVien(String MaSinhVien);
    void edit(SinhVienInforRequestDto sinhVien);
    List<SinhVien> getAll();
    boolean isSinhVienIsExists (String maSinhVien);
    boolean isCccdIsValid(String Cccd);
    boolean isEmailIsValid(String Email);

}
