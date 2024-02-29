package com.example.QLKTX.service.impl;

import com.example.QLKTX.entity.HopDongThuePhong;
import com.example.QLKTX.repository.IHopDongThuePhongRepository;
import com.example.QLKTX.service.IHopDongThuePhongService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;


@Service
@RequiredArgsConstructor
public class HopDongThuePhongService implements IHopDongThuePhongService {
    @Autowired
    private IHopDongThuePhongRepository hopDongThuePhongRepository;

    @Override
    public HopDongThuePhong getHopDongThuePhongbySinhVienID(Integer sinhVienID) {

        return hopDongThuePhongRepository.findBySinhVienId(sinhVienID);
    }
}
