package com.example.QLKTX.service;
import com.example.QLKTX.dto.LoginRequestDto;
import  com.example.QLKTX.entity.NguoiDung;
public interface INguoiDungService {
     NguoiDung getNguoiDungByTenNguoiDung(String TenNguoiDung);

     NguoiDung getNguoiDungbyNguoiDungID(Integer nguoiDungID);

     String login(LoginRequestDto authenticationRequest);


}
