package com.example.QLKTX.service.impl;

import com.example.QLKTX.entity.Phong;
import com.example.QLKTX.repository.IPhongRepository;
import com.example.QLKTX.service.IPhongService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class PhongService implements IPhongService {

    @Autowired
    private IPhongRepository PhongRepository;
    @Override
    public Phong getPhongbySoPhongSinhVien(String soPhong) {
        return PhongRepository.findBySoPhong(soPhong);
    }

}
