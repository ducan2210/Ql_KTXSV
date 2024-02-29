package com.example.QLKTX.service.impl;

import com.example.QLKTX.dto.LoginRequestDto;
import com.example.QLKTX.entity.NguoiDung;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.repository.INguoiDungRepository;
import com.example.QLKTX.repository.ISinhVienRepository;
import com.example.QLKTX.security.JwtTokenUtil;
import com.example.QLKTX.service.INguoiDungService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.AuthenticationServiceException;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class NguoiDungService implements INguoiDungService {

    @Autowired
    INguoiDungRepository nguoiDungRepository;
    @Autowired
    private JwtTokenUtil jwtTokenUtil;
    @Autowired
    private final ISinhVienRepository repository;

    @Override
    public NguoiDung getNguoiDungByTenNguoiDung(String TenNguoiDung) {
        return  nguoiDungRepository.findByTenNguoiDung(TenNguoiDung);
    }

    @Override
    public NguoiDung getNguoiDungbyNguoiDungID(Integer nguoiDungID) {
        return nguoiDungRepository.findByNguoiDungId(nguoiDungID);
    }
    @Override
    public String login(LoginRequestDto authenticationRequest) {
        NguoiDung tk = nguoiDungRepository.findByTenNguoiDung(authenticationRequest.getUsername());

        if(!authenticationRequest.getPassword().equals(tk.getMatKhau())){
            throw new AuthenticationServiceException("Wrong password");
        }
        else
        {
            SinhVien sv = repository.findByMaSinhVien(authenticationRequest.getUsername());
            return jwtTokenUtil.generateToken(sv);
        }

    }

}
