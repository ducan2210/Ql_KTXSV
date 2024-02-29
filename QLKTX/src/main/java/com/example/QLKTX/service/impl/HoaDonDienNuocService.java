package com.example.QLKTX.service.impl;

import com.example.QLKTX.entity.HoaDonDienNuoc;
import com.example.QLKTX.repository.IHoaDonDienNuocRepository;
import com.example.QLKTX.service.IHoaDonDienNuocService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class HoaDonDienNuocService implements IHoaDonDienNuocService {
    @Autowired
    private IHoaDonDienNuocRepository hoaDonDienNuocRepository;

    @Override
    public HoaDonDienNuoc gethdbyPhongid(Integer phongId) {
        return hoaDonDienNuocRepository.findByPhongId(phongId);
    }
}
